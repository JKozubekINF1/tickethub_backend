using CinematicketBackend.Data;
using CinematicketBackend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace CinematicketBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BiletyController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public BiletyController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpPost("kup")]
        [Authorize] 
        public async Task<IActionResult> KupBilet(int seansId, int numerMiejsca)
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!int.TryParse(userIdClaim, out var userId))
                return Unauthorized("Nieprawidłowy token");

            var user = await _db.Users.FindAsync(userId);
            if (user == null)
                return Unauthorized("Użytkownik nie istnieje");

            var seans = await _db.Seanse
                .Include(s => s.Sala)
                .FirstOrDefaultAsync(s => s.Id == seansId);

            if (seans == null)
                return NotFound("Seans nie istnieje");

            if (numerMiejsca < 1 || numerMiejsca > seans.Sala!.LiczbaMiejsc)
                return BadRequest($"Numer miejsca musi być w zakresie 1-{seans.Sala.LiczbaMiejsc}");

            var miejsceZajete = await _db.Bilety
                .AnyAsync(b => b.SeansId == seansId && b.NumerMiejsca == numerMiejsca);

            if (miejsceZajete)
                return BadRequest("Wybrane miejsce jest już zajęte");

            var bilet = new Bilet
            {
                SeansId = seansId,
                NumerMiejsca = numerMiejsca,
                UserId = userId 
            };

            _db.Bilety.Add(bilet);
            await _db.SaveChangesAsync();

            return Ok(new
            {
                bilet.Id,
                bilet.SeansId,
                bilet.NumerMiejsca,
                bilet.UserId
            });
        }

        [HttpGet("dostepne/{seansId}")]
        public async Task<IActionResult> DostepneMiejsca(int seansId)
        {
            var seans = await _db.Seanse
                .Include(s => s.Sala)
                .FirstOrDefaultAsync(s => s.Id == seansId);

            if (seans == null)
                return NotFound("Seans nie istnieje");

            var zajeteMiejsca = await _db.Bilety
                .Where(b => b.SeansId == seansId)
                .Select(b => b.NumerMiejsca)
                .ToListAsync();

            var wszystkieMiejsca = Enumerable.Range(1, seans.Sala!.LiczbaMiejsc);
            var wolneMiejsca = wszystkieMiejsca.Except(zajeteMiejsca);

            return Ok(new
            {
                SeansId = seansId,
                WolneMiejsca = wolneMiejsca
            });
        }

        [HttpGet("moje")]
        [Authorize]
        public async Task<IActionResult> MojeBilety()
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!int.TryParse(userIdClaim, out var userId))
                return Unauthorized("Nieprawidłowy token");

            var bilety = await _db.Bilety
                .Include(b => b.Seans)
                .ThenInclude(s => s.Sala)
                .Where(b => b.UserId == userId) 
                .Where(b => b.Seans.Sala != null)
                .ToListAsync();

            return Ok(bilety.Select(b => new
            {
                b.Id,
                b.SeansId,
                b.NumerMiejsca,
                SeansTytul = b.Seans.Tytul,
                SeansData = b.Seans.Data,
                SeansGodzina = b.Seans.Godzina,
                Sala = b.Seans.Sala?.Nazwa,
                Miejscowosc = b.Seans.Miejscowosc
            }));
        }


        [HttpDelete("anuluj/{biletId}")]
        [Authorize] 
        public async Task<IActionResult> AnulujBilet(int biletId)
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!int.TryParse(userIdClaim, out var userId))
                return Unauthorized("Nieprawidłowy token");

            var bilet = await _db.Bilety
                .Include(b => b.Seans)
                .FirstOrDefaultAsync(b => b.Id == biletId);
            if (bilet == null)
                return NotFound("Bilet nie został znaleziony");

            if (bilet.UserId != userId)
                return Forbid("Nie masz uprawnień do anulowania tego biletu");

            _db.Bilety.Remove(bilet);
            await _db.SaveChangesAsync();

            return Ok(new { message = "Bilet został anulowany pomyślnie." });
        }
    }
}