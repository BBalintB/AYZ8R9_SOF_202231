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
    public class SprintLogicTest
    {
        SprintLogic logic;

        [SetUp]
        public void Init()
        {
            Mock<ISprintRepository> mockSprintRepo = new Mock<ISprintRepository>();
            mockSprintRepo.Setup(x => x.GetAll()).Returns(this.FakeUser());
            logic = new SprintLogic(mockSprintRepo.Object);
        }

        [Test]
        public void SprintDoesNotExistExceptionThrown()
        {
            var xy = Assert.Throws<ItemDoesNotExistException>(() => logic.DeleteSprint("24"));
        }

        private IQueryable<Sprint> FakeUser()
        {
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

            Project testProject = new Project()
            {
                ProjectName = "Test Project 1"
            };

            testProject.Owner = admin;
            testProject.OwnerId = admin.Id;

            Sprint testSprint = new Sprint()
            {
                SprintName = "First test sprint",
                SprintDueDate = "2023.01.20."
            };

            testSprint.ProjectId = testProject.ProjectId;
            testSprint.Project = testProject;

            List<Sprint> sprints = new List<Sprint>();
            sprints.Add(testSprint);

            return sprints.AsQueryable();
        }
    }
}
