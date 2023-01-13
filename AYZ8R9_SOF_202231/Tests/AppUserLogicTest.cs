using AYZ8R9_SOF_202231.Logic;
using AYZ8R9_SOF_202231.Logic.Exceptions;
using AYZ8R9_SOF_202231.Model;
using AYZ8R9_SOF_202231.Repository;
using Microsoft.AspNetCore.Identity;
using Moq;
using NUnit.Framework;

namespace AYZ8R9_SOF_202231.Tests
{
    [TestFixture]
    public class AppUserLogicTest
    {
        AppUserLogic logic;

        [SetUp]
        public void Init() {
            Mock<IAppUserRepository> mockUserRepo = new Mock<IAppUserRepository>();
            mockUserRepo.Setup(x => x.GetAll()).Returns(this.FakeUser());
            logic = new AppUserLogic(mockUserRepo.Object);
        }
        [Test]
        public void UserAlreadyExistExceptionThrown() {
            Assert.Throws<ItemAlreadyExistException>(() => logic.CreateUser(new AppUser() { Email = "admin1@admin.com", UserName = "admin1", FirstName="Test", LastName="Case"}));
        }

        [Test]
        public void UserDoesNotExistExceptionThrown()
        {
            var xy = Assert.Throws<ItemDoesNotExistException>(() => logic.DeleteUser("24"));
        }


        private IQueryable<AppUser> FakeUser() {
            PasswordHasher<AppUser> ph = new PasswordHasher<AppUser>();
            AppUser admin = new AppUser
            {
                Id = Guid.NewGuid().ToString(),
                Email = "admin1@admin.com",
                EmailConfirmed = true,
                UserName = "admin1",
                FirstName = "Big",
                LastName = "Boss",
                NormalizedUserName = "ADMIN",
            };
            admin.PasswordHash = ph.HashPassword(admin, "pirosalma");

            List<AppUser> users = new List<AppUser>();
            users.Add(admin);

            return users.AsQueryable();
        }
    }
}
