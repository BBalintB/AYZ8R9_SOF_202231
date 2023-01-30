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
        public void OwnerCantSignUpExceptionThrown()
        {
            AppUser a1 = new AppUser() { UserName = "projectadmin", FirstName = "Big", LastName = "Boss", Email = "projectadmin@admin.com" };
            Project p1 = new Project() { ProjectName = "Test Project 1", Owner =  a1};
            ProjectAppUser pa1 = new ProjectAppUser() { User = a1, Project = p1, ProjectId = p1.ProjectId };
            Assert.Throws<ItemAlreadyExistException>(() => logic.CreatePA(pa1));
        }

        [Test]
        public void PAConnectionDoesNotExistExceptionThrown()
        {
            var xy = Assert.Throws<ItemDoesNotExistException>(() => logic.DeletePA("24","16"));
        }

        [Test]
        public void ProjectAlreadyFullExceptionThrown()
        {
            AppUser a1 = new AppUser() { UserName = "projectadmin", FirstName = "Big", LastName = "Boss", Email = "projectadmin@admin.com" };
            AppUser a2 = new AppUser() { UserName = "test", FirstName = "Big", LastName = "Boss", Email = "test@admin.com" };
            Project p1 = logic.GetAllPA().FirstOrDefault(x => x.ConnectionId == "1").Project;
            ProjectAppUser pa1 = new ProjectAppUser() { User = a2, Project = p1, ProjectId = p1.ProjectId };
            var xy = Assert.Throws<ProjectAlreadyFullException>(() => logic.CreatePA(pa1));
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

            AppUser testuser = new AppUser
            {
                Id = Guid.NewGuid().ToString(),
                Email = "testuser@user.com",
                EmailConfirmed = true,
                UserName = "testuser",
                FirstName = "Big",
                LastName = "Boss",
                NormalizedUserName = "ADMIN",
            };
            testuser.PasswordHash = ph.HashPassword(testuser, "pirosalma");

            AppUser testuser1 = new AppUser
            {
                Id = Guid.NewGuid().ToString(),
                Email = "testuser1@user.com",
                EmailConfirmed = true,
                UserName = "testuser1",
                FirstName = "Big",
                LastName = "Boss",
                NormalizedUserName = "ADMIN",
            };
            testuser1.PasswordHash = ph.HashPassword(testuser1, "pirosalma");

            AppUser testuser2 = new AppUser
            {
                Id = Guid.NewGuid().ToString(),
                Email = "testuser2@user.com",
                EmailConfirmed = true,
                UserName = "testuser2",
                FirstName = "Big",
                LastName = "Boss",
                NormalizedUserName = "ADMIN",
            };
            testuser2.PasswordHash = ph.HashPassword(testuser2, "pirosalma");

            AppUser testuser3 = new AppUser
            {
                Id = Guid.NewGuid().ToString(),
                Email = "testuser3@user.com",
                EmailConfirmed = true,
                UserName = "testuser3",
                FirstName = "Big",
                LastName = "Boss",
                NormalizedUserName = "ADMIN",
            };
            testuser3.PasswordHash = ph.HashPassword(testuser3, "pirosalma");

            AppUser testuser4 = new AppUser
            {
                Id = Guid.NewGuid().ToString(),
                Email = "testuser4@user.com",
                EmailConfirmed = true,
                UserName = "testuser4",
                FirstName = "Big",
                LastName = "Boss",
                NormalizedUserName = "ADMIN",
            };
            testuser4.PasswordHash = ph.HashPassword(testuser4, "pirosalma");

            AppUser testuser5 = new AppUser
            {
                Id = Guid.NewGuid().ToString(),
                Email = "testuser5@user.com",
                EmailConfirmed = true,
                UserName = "testuser5",
                FirstName = "Big",
                LastName = "Boss",
                NormalizedUserName = "ADMIN",
            };
            testuser5.PasswordHash = ph.HashPassword(testuser5, "pirosalma");

            AppUser testuser6 = new AppUser
            {
                Id = Guid.NewGuid().ToString(),
                Email = "testuser6@user.com",
                EmailConfirmed = true,
                UserName = "testuser6",
                FirstName = "Big",
                LastName = "Boss",
                NormalizedUserName = "ADMIN",
            };
            testuser6.PasswordHash = ph.HashPassword(testuser6, "pirosalma");

            AppUser testuser7 = new AppUser
            {
                Id = Guid.NewGuid().ToString(),
                Email = "testuser7@user.com",
                EmailConfirmed = true,
                UserName = "testuser7",
                FirstName = "Big",
                LastName = "Boss",
                NormalizedUserName = "ADMIN",
            };
            testuser7.PasswordHash = ph.HashPassword(testuser7, "pirosalma");

            AppUser testuser8 = new AppUser
            {
                Id = Guid.NewGuid().ToString(),
                Email = "testuser8@user.com",
                EmailConfirmed = true,
                UserName = "testuser8",
                FirstName = "Big",
                LastName = "Boss",
                NormalizedUserName = "ADMIN",
            };
            testuser8.PasswordHash = ph.HashPassword(testuser8, "pirosalma");

            AppUser testuser9 = new AppUser
            {
                Id = Guid.NewGuid().ToString(),
                Email = "testuser9@user.com",
                EmailConfirmed = true,
                UserName = "testuser9",
                FirstName = "Big",
                LastName = "Boss",
                NormalizedUserName = "ADMIN",
            };
            testuser9.PasswordHash = ph.HashPassword(testuser9, "pirosalma");





            Project testProject = new Project()
            {
                ProjectId = "11",
                ProjectName = "Test Project 1"
            };

            testProject.ProjectUsers = new List<ProjectAppUser>();

            testProject.Owner = admin;
            testProject.OwnerId = admin.Id;

            ProjectAppUser testPA = new ProjectAppUser()
            {
                ConnectionId = "1",
                AppUserId = admin.Id,
                User = admin,
                ProjectId = testProject.ProjectId,
                Project = testProject
            };

            ProjectAppUser testPA2 = new ProjectAppUser()
            {
                AppUserId = testuser.Id,
                User = testuser,
                ProjectId = testProject.ProjectId,
                Project = testProject
            };

            ProjectAppUser testPA3 = new ProjectAppUser()
            {
                AppUserId = testuser1.Id,
                User = testuser1,
                ProjectId = testProject.ProjectId,
                Project = testProject
            };

            ProjectAppUser testPA4 = new ProjectAppUser()
            {
                AppUserId = testuser2.Id,
                User = testuser2,
                ProjectId = testProject.ProjectId,
                Project = testProject
            };

            ProjectAppUser testPA5 = new ProjectAppUser()
            {
                AppUserId = testuser3.Id,
                User = testuser3,
                ProjectId = testProject.ProjectId,
                Project = testProject
            };
            ProjectAppUser testPA6 = new ProjectAppUser()
            {
                AppUserId = testuser4.Id,
                User = testuser4,
                ProjectId = testProject.ProjectId,
                Project = testProject
            };
            ProjectAppUser testPA7 = new ProjectAppUser()
            {
                AppUserId = testuser5.Id,
                User = testuser5,
                ProjectId = testProject.ProjectId,
                Project = testProject
            };
            ProjectAppUser testPA8 = new ProjectAppUser()
            {
                AppUserId = testuser6.Id,
                User = testuser6,
                ProjectId = testProject.ProjectId,
                Project = testProject
            };
            ProjectAppUser testPA9 = new ProjectAppUser()
            {
                AppUserId = testuser7.Id,
                User = testuser7,
                ProjectId = testProject.ProjectId,
                Project = testProject
            };

            ProjectAppUser testPA10 = new ProjectAppUser()
            {
                AppUserId = testuser8.Id,
                User = testuser8,
                ProjectId = testProject.ProjectId,
                Project = testProject
            };

            ProjectAppUser testPA11 = new ProjectAppUser()
            {
                AppUserId = testuser9.Id,
                User = testuser9,
                ProjectId = testProject.ProjectId,
                Project = testProject
            };

            testProject.ProjectUsers.Add(testPA);
            testProject.ProjectUsers.Add(testPA2);
            testProject.ProjectUsers.Add(testPA3);
            testProject.ProjectUsers.Add(testPA4);
            testProject.ProjectUsers.Add(testPA5);
            testProject.ProjectUsers.Add(testPA6);
            testProject.ProjectUsers.Add(testPA7);
            testProject.ProjectUsers.Add(testPA8);
            testProject.ProjectUsers.Add(testPA9);
            testProject.ProjectUsers.Add(testPA10);

            List<ProjectAppUser> pa = new List<ProjectAppUser>();
            pa.Add(testPA);
            pa.Add(testPA2);
            pa.Add(testPA3);
            pa.Add(testPA4);
            pa.Add(testPA5);
            pa.Add(testPA6);
            pa.Add(testPA7);
            pa.Add(testPA8);
            pa.Add(testPA9);
            pa.Add(testPA10);
            ;
            return pa.AsQueryable();
        }
    }
}
