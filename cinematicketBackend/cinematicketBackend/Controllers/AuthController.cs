using cinematicketBackend.Models;
using CinematicketBackend.Data;
using CinematicketBackend.Models;
using CinematicketBackend.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Security.Cryptography;

namespace CinematicketBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly IPasswordHasher<User> _hasher;
        private readonly JwtService _jwt;
        private readonly IEmailService _emailService;

        public AuthController(
            ApplicationDbContext db,
            IPasswordHasher<User> hasher,
            JwtService jwt,
            IEmailService emailService)
        {
            _db = db;
            _hasher = hasher;
            _jwt = jwt;
            _emailService = emailService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDto dto)
        {
            if (await _db.Users.AnyAsync(u => u.Username == dto.Username))
                return Conflict("Username zajęty");
            if (await _db.Users.AnyAsync(u => u.Email == dto.Email))
                return Conflict("Email zajęty");

            var user = new User
            {
                Username = dto.Username,
                Email = dto.Email,
                PasswordHash = _hasher.HashPassword(null!, dto.Password)
            };

            _db.Users.Add(user);
            await _db.SaveChangesAsync();

            return Ok(new { user.Id, user.Username });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            var user = await _db.Users.FirstOrDefaultAsync(u => u.Username == dto.Username);
            if (user == null) return Unauthorized("Nieprawidłowe dane");

            var res = _hasher.VerifyHashedPassword(user, user.PasswordHash, dto.Password);
            if (res == PasswordVerificationResult.Failed) return Unauthorized("Nieprawidłowe dane");

            var token = _jwt.GenerateToken(user);
            return Ok(new { token, user.Id, user.Username });
        }

        [Authorize]
        [HttpGet("profile")]
        public async Task<IActionResult> Profile()
        {
            var idClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!int.TryParse(idClaim, out var userId))
                return Unauthorized(new { message = "Nieprawidłowy token." });

            var user = await _db.Users.FindAsync(userId);
            if (user == null)
                return NotFound(new { message = "Użytkownik nie znaleziony." });

            return Ok(new
            {
                user.Username,
                user.Email
            });
        }

        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordDto dto)
        {
            var user = await _db.Users.FirstOrDefaultAsync(u => u.Email == dto.Email);
            if (user == null)
            {
                return NotFound("Użytkownik o podanym emailu nie istnieje.");
            }

            var token = Convert.ToHexString(RandomNumberGenerator.GetBytes(64));

            user.PasswordResetToken = token;
            user.ResetTokenExpires = DateTime.Now.AddMinutes(15);
            await _db.SaveChangesAsync();

            var emailBody = $@"
                <h3>Resetowanie hasła - TicketHUB</h3>
                <p>Otrzymaliśmy prośbę o reset hasła dla Twojego konta.</p>
                <p>Twój kod to: <b style='font-size: 1.2em; color: #ff9900;'>{token}</b></p>
                <p>Kod jest ważny przez 15 minut.</p>";

            try
            {
                _emailService.SendEmail(user.Email, "Reset hasła", emailBody);
                return Ok("Link resetujący został wysłany na email.");
            }
            catch (Exception ex)
            {
                return BadRequest("Nie udało się wysłać maila: " + ex.Message);
            }
        }

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword(ResetPasswordDto dto)
        {
            if (dto.NewPassword != dto.ConfirmPassword)
                return BadRequest("Hasła nie są identyczne.");

            var user = await _db.Users.FirstOrDefaultAsync(u => u.PasswordResetToken == dto.Token);

            if (user == null || user.ResetTokenExpires < DateTime.Now)
            {
                return BadRequest("Token jest nieprawidłowy lub wygasł.");
            }

            user.PasswordHash = _hasher.HashPassword(user, dto.NewPassword);

            user.PasswordResetToken = null;
            user.ResetTokenExpires = null;

            await _db.SaveChangesAsync();

            return Ok("Hasło zostało pomyślnie zmienione.");
        }
    }
}