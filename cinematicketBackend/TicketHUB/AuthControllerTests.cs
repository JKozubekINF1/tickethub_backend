using cinematicketBackend.Models;
using CinematicketBackend.Controllers;
using CinematicketBackend.Data;
using CinematicketBackend.Models;
using CinematicketBackend.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace CinematicketBackend.Tests
{
    public class AuthControllerTests
    {
        private ApplicationDbContext GetDatabaseContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            return new ApplicationDbContext(options);
        }

        [Fact]
        public async Task Register_Sukces_GdyDanePoprawne()
        {
            var db = GetDatabaseContext();
            var mockHasher = new Mock<IPasswordHasher<User>>();
            mockHasher.Setup(h => h.HashPassword(It.IsAny<User>(), It.IsAny<string>()))
                      .Returns("hashed_secret");

            var controller = new AuthController(db, mockHasher.Object, null!);
            var dto = new RegisterDto { Username = "new", Email = "new@test.com", Password = "123" };

            var result = await controller.Register(dto);

            Assert.IsType<OkObjectResult>(result);
            Assert.Equal(1, await db.Users.CountAsync());
        }

        [Fact]
        public async Task Register_Conflict_GdyUserIstnieje()
        {

            var db = GetDatabaseContext();
            db.Users.Add(new User { Username = "stary", Email = "old@test.com", PasswordHash = "x" });
            await db.SaveChangesAsync();

            var mockHasher = new Mock<IPasswordHasher<User>>();
            var controller = new AuthController(db, mockHasher.Object, null!);
            var dto = new RegisterDto { Username = "stary", Email = "inny@test.com", Password = "123" };

            var result = await controller.Register(dto);

            var conflict = Assert.IsType<ConflictObjectResult>(result);
            Assert.Equal("Username zajęty", conflict.Value);
        }
    }
}