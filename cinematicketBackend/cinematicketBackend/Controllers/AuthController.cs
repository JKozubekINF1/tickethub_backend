using cinematicketBackend.Models;
using CinematicketBackend.Data;
using CinematicketBackend.Models;
using CinematicketBackend.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;


namespace CinematicketBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly IPasswordHasher<User> _hasher;
        private readonly JwtService _jwt;

        public AuthController(ApplicationDbContext db, IPasswordHasher<User> hasher, JwtService jwt)
        {
            _db = db;
            _hasher = hasher;
            _jwt = jwt;
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

    }
}
