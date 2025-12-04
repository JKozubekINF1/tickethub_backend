using CinematicketBackend.Data;
using CinematicketBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CinematicketBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SeanseController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public SeanseController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var seanse = await _db.Seanse
                .Include(s => s.Sala)
                .Select(s => new
                {
                    s.Id,
                    s.SalaId,
                    s.Miejscowosc,
                    s.Tytul,
                    s.TypSeansu,
                    s.Data,
                    s.Godzina,
                    s.Gatunek,
                    s.WiekMin,
                    Sala = new
                    {
                        s.Sala.Id,
                        s.Sala.Nazwa,
                        s.Sala.LiczbaMiejsc
                    }
                })
                .ToListAsync();
            return Ok(seanse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var seans = await _db.Seanse.FindAsync(id);
            if (seans == null) return NotFound();
            return Ok(seans);
        }

        [HttpGet("search")]
        public async Task<IActionResult> Search(
            [FromQuery] string? tytul,
            [FromQuery] string? miejscowosc,
            [FromQuery] string? gatunek,
            [FromQuery] DateTime? data)
        {
            var query = _db.Seanse.AsQueryable();

            if (!string.IsNullOrEmpty(tytul))
                query = query.Where(s => s.Tytul.Contains(tytul));

            if (!string.IsNullOrEmpty(miejscowosc))
                query = query.Where(s => s.Miejscowosc.Contains(miejscowosc));

            if (!string.IsNullOrEmpty(gatunek))
                query = query.Where(s => s.Gatunek.Contains(gatunek));

            if (data.HasValue)
                query = query.Where(s => s.Data.Date == data.Value.Date);

            var result = await query.ToListAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Seans seans)
        {
            _db.Seanse.Add(seans);
            await _db.SaveChangesAsync();
            return Ok(seans);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Seans seans)
        {
            var existing = await _db.Seanse.FindAsync(id);
            if (existing == null) return NotFound();

            existing.Miejscowosc = seans.Miejscowosc;
            existing.Tytul = seans.Tytul;
            existing.TypSeansu = seans.TypSeansu;
            existing.Data = seans.Data;
            existing.Godzina = seans.Godzina;
            existing.Gatunek = seans.Gatunek;
            existing.WiekMin = seans.WiekMin;

            await _db.SaveChangesAsync();
            return Ok(existing);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var seans = await _db.Seanse.FindAsync(id);
            if (seans == null) return NotFound();

            _db.Seanse.Remove(seans);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
