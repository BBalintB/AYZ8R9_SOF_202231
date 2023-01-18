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
    public class UserStoryLogicTest
    {
        UserStoryLogic logic;

        [SetUp]
        public void Init()
        {
            Mock<IUserStoryRepository> mockStoryRepo = new Mock<IUserStoryRepository>();
            mockStoryRepo.Setup(x => x.GetAll()).Returns(this.FakeUser());
            logic = new UserStoryLogic(mockStoryRepo.Object);
        }

        [Test]
        public void StoryDoesNotExistExceptionThrown()
        {
            var xy = Assert.Throws<ItemDoesNotExistException>(() => logic.DeleteStory("24"));
        }

        private IQueryable<UserStory> FakeUser()
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

            UserStory testStory = new UserStory()
            {
                UserStoryName = "Test story",
                UserStoryPriority = 7
            };

            testStory.SprintId = testSprint.SprintId;
            testStory.Sprint = testSprint;

            List<UserStory> stories = new List<UserStory>();
            stories.Add(testStory);

            return stories.AsQueryable();
        }
    }
}
