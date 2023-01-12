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
    public class ProjectLogicTest
    {
        ProjectLogic logic;

        [SetUp]
        public void Init()
        {
            Mock<IProjectRepository> mockProjectRepo = new Mock<IProjectRepository>();
            mockProjectRepo.Setup(x => x.GetAll()).Returns(this.FakeProject());
            logic = new ProjectLogic(mockProjectRepo.Object);
        }

        [Test]
        public void UserAlreadyExistExceptionThrown()
        {
            Assert.Throws<ItemAlreadyExistException>(() => logic.CreateProject(new Project() { ProjectName = "Test Project 1", Owner = new AppUser() { UserName = "projectadmin", FirstName = "Big", LastName = "Boss", Email= "projectadmin@admin.com" } }));
        }

        [Test]
        public void UserDoesNotExistExceptionThrown()
        {
            var xy = Assert.Throws<ItemDoesNotExistException>(() => logic.DeleteProject("24"));
        }

        private IQueryable<Project> FakeProject()
        {
            PasswordHasher<AppUser> ph = new PasswordHasher<AppUser>();
            AppUser admin = new AppUser
            {
                Id = Guid.NewGuid().ToString(),
                Email = "projectadmin@admin.com",
                EmailConfirmed = true,
                UserName = "projectadmin",
                FirstName = "Big",
                LastName = "Boss",
                NormalizedUserName = "ADMIN",
            };
            admin.PasswordHash = ph.HashPassword(admin, "pirosalma");

            

            Project testProject = new Project()
            {
                ProjectName = "Test Project 1"
            };

            testProject.Owner = admin;
            testProject.OwnerId = admin.Id;

            List<Project> projects = new List<Project>();
            projects.Add(testProject);
            ;
            return projects.AsQueryable();
        }
    }
}
