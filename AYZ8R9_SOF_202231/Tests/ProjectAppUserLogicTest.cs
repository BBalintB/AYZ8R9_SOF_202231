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
    public class ProjectAppUserLogicTest
    {
        ProjectAppUserLogic logic;

        [SetUp]
        public void Init()
        {
            Mock<IProjectAppUserRepository> mockPARepo = new Mock<IProjectAppUserRepository>();
            mockPARepo.Setup(x => x.GetAll()).Returns(this.FakeProject());
            logic = new ProjectAppUserLogic(mockPARepo.Object);
        }

        [Test]
        public void PAConnectionAlreadyExistExceptionThrown()
        {
            AppUser a1 = new AppUser() { UserName = "projectadmin", FirstName = "Big", LastName = "Boss", Email = "projectadmin@admin.com" };
            Project p1 = new Project() { ProjectName = "Test Project 1", Owner =  a1};
            ProjectAppUser pa1 = new ProjectAppUser() { User = a1, Project = p1, ProjectId = p1.ProjectId };
            Assert.Throws<ItemAlreadyExistException>(() => logic.CreatePA(pa1));
        }

        [Test]
        public void PAConnectionDoesNotExistExceptionThrown()
        {
            var xy = Assert.Throws<ItemDoesNotExistException>(() => logic.DeletePA("24"));
        }

        private IQueryable<ProjectAppUser> FakeProject()
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

            ProjectAppUser testPA = new ProjectAppUser()
            {
                AppUserId = admin.Id,
                User = admin,
                ProjectId = testProject.ProjectId,
                Project = testProject
            };

            List<ProjectAppUser> pa = new List<ProjectAppUser>();
            pa.Add(testPA);
            ;
            return pa.AsQueryable();
        }
    }
}
