using cinematicketBackend.Models;
using CinematicketBackend.Controllers;
using CinematicketBackend.Data;
using CinematicketBackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Xunit;

namespace CinematicketBackend.Tests
{
    public class BiletyControllerTests
    {
        private ApplicationDbContext GetDatabaseContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            var databaseContext = new ApplicationDbContext(options);

            databaseContext.Database.EnsureCreated();

            return databaseContext;
        }

        private void MockUserInController(ControllerBase controller, int userId)
        {
            var user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.NameIdentifier, userId.ToString())
            }, "mock"));

            controller.ControllerContext = new ControllerContext()
            {
                HttpContext = new DefaultHttpContext() { User = user }
            };
        }

        [Fact]
        public async Task KupBilet_Sukces_GdyMiejsceWolne()
        {

            var db = GetDatabaseContext();

            var user = new User { Id = 901, Username = "test", Email = "t@t.com", PasswordHash = "x" };
            var sala = new Sala { Id = 901, Nazwa = "S1", LiczbaMiejsc = 100 };
            var seans = new Seans { Id = 901, SalaId = 901, Tytul = "Film", Data = DateTime.Now.AddDays(1), Godzina = "18:00", Miejscowosc = "Lubin", TypSeansu = "2D", Gatunek = "Akcja", WiekMin = 12 };

            db.Users.Add(user);
            db.Sale.Add(sala);
            db.Seanse.Add(seans);
            await db.SaveChangesAsync();

            var controller = new BiletyController(db);
            MockUserInController(controller, 901);

            var result = await controller.KupBilet(seansId: 901, numerMiejsca: 5);

            Assert.IsType<OkObjectResult>(result);
            var bilet = await db.Bilety.FirstOrDefaultAsync(b => b.SeansId == 901 && b.NumerMiejsca == 5);
            Assert.NotNull(bilet);
        }

        [Fact]
        public async Task KupBilet_Blad_GdyMiejsceZajete()
        {

            var db = GetDatabaseContext();
            var user = new User { Id = 902, Username = "u", Email = "e", PasswordHash = "p" };

            var sala = new Sala { Id = 902, Nazwa = "S2", LiczbaMiejsc = 50 };
            var seans = new Seans { Id = 902, SalaId = 902, Tytul = "F", Data = DateTime.Now, Godzina = "10:00", Miejscowosc = "X", TypSeansu = "X", Gatunek = "X", WiekMin = 0 };

            db.Users.Add(user);
            db.Sale.Add(sala);
            db.Seanse.Add(seans);
            db.Bilety.Add(new Bilet { Id = 902, SeansId = 902, NumerMiejsca = 5, UserId = 902 });
            await db.SaveChangesAsync();

            var controller = new BiletyController(db);
            MockUserInController(controller, 902);

            var result = await controller.KupBilet(seansId: 902, numerMiejsca: 5);

            var badRequest = Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal("Wybrane miejsce jest już zajęte", badRequest.Value);
        }

        [Fact]
        public async Task AnulujBilet_Sukces_GdyJestWlascicielem()
        {

            var db = GetDatabaseContext();
            var user = new User { Id = 903, Username = "owner", Email = "o", PasswordHash = "p" };
            var sala = new Sala { Id = 903, Nazwa = "S3", LiczbaMiejsc = 50 };
            var seans = new Seans { Id = 903, SalaId = 903, Tytul = "F", Data = DateTime.Now.AddDays(5), Godzina = "12:00", Miejscowosc = "X", TypSeansu = "X", Gatunek = "X", WiekMin = 0 };
            var bilet = new Bilet { Id = 903, UserId = 903, SeansId = 903, NumerMiejsca = 1 };

            db.Users.Add(user);
            db.Sale.Add(sala);
            db.Seanse.Add(seans);
            db.Bilety.Add(bilet);
            await db.SaveChangesAsync();

            var controller = new BiletyController(db);
            MockUserInController(controller, 903);

            var result = await controller.AnulujBilet(903);

            Assert.IsType<OkObjectResult>(result);
            Assert.Null(await db.Bilety.FindAsync(903));
        }

        [Fact]
        public async Task AnulujBilet_Zabronione_GdyNieJestWlascicielem()
        {

            var db = GetDatabaseContext();
            var wlasciciel = new User { Id = 904, Username = "A", Email = "A", PasswordHash = "A" };
            var zlodziej = new User { Id = 905, Username = "B", Email = "B", PasswordHash = "B" };

            var sala = new Sala { Id = 904, Nazwa = "S4", LiczbaMiejsc = 50 };
            var seans = new Seans { Id = 904, SalaId = 904, Tytul = "F", Data = DateTime.Now.AddDays(5), Godzina = "12:00", Miejscowosc = "X", TypSeansu = "X", Gatunek = "X", WiekMin = 0 };

            var bilet = new Bilet { Id = 904, UserId = 904, SeansId = 904, NumerMiejsca = 1 };

            db.Users.Add(wlasciciel);
            db.Users.Add(zlodziej);
            db.Sale.Add(sala);
            db.Seanse.Add(seans);
            db.Bilety.Add(bilet);
            await db.SaveChangesAsync();

            var controller = new BiletyController(db);
            MockUserInController(controller, 905); 

            var result = await controller.AnulujBilet(904);

            Assert.IsType<ForbidResult>(result);
            Assert.NotNull(await db.Bilety.FindAsync(904));
        }
    }
}