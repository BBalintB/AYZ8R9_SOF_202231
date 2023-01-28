using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using AYZ8R9_SOF_202231.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace AYZ8R9_SOF_202231.Data
{
    public class SCRUMDbContext : IdentityDbContext<AppUser>
    {
        public SCRUMDbContext(DbContextOptions<SCRUMDbContext> options) : base(options)
        {
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Project> Projects{ get; set; }
        public DbSet<Sprint> Sprints{ get; set; }
        public DbSet<UserStory> UserStories{ get; set; }
        public DbSet<ProjectAppUser> ProjectAppUsersConnection{ get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            PasswordHasher<AppUser> ph = new PasswordHasher<AppUser>();

            AppUser admin = new AppUser
            {
                Id = Guid.NewGuid().ToString(),
                Email = "admin@admin.com",
                EmailConfirmed = true,
                UserName = "admin@admin.com",
                FirstName = "Big",
                LastName = "Boss",
                NormalizedUserName = "ADMIN@ADMIN.com",
                
            };
            admin.PasswordHash = ph.HashPassword(admin, "Pirosalma123!");


            Project TestProject = new Project() { ProjectName = "Test Project", OwnerId = admin.Id };

            Sprint TestSprint = new Sprint() { SprintName = "Test Sprint", SprintDueDate = "2022.12.14", ProjectId = TestProject.ProjectId };
            Sprint TestSprint1 = new Sprint() { SprintName = "Test Sprint1", SprintDueDate = "2022.12.24", ProjectId = TestProject.ProjectId };
            Sprint TestSprint2 = new Sprint() { SprintName = "Test Sprint2", SprintDueDate = "2022.12.30", ProjectId = TestProject.ProjectId };

            UserStory TestStory = new UserStory() { UserStoryName = "Test user story 1", UserStoryDescription = "Just a test",UserStoryPriority = 5, SprintId = TestSprint.SprintId };
            UserStory TestStory1 = new UserStory() { UserStoryName = "Test user story 2", UserStoryDescription = "Just a test", UserStoryPriority = 3, SprintId = TestSprint.SprintId };
            UserStory TestStory2 = new UserStory() { UserStoryName = "Test user story 3", UserStoryDescription = "Just a test", UserStoryPriority = 11, SprintId = TestSprint1.SprintId };


            ProjectAppUser PA1 = new ProjectAppUser() { ProjectId = TestProject.ProjectId, AppUserId = admin.Id };


            builder.Entity<Sprint>()
                .HasOne(Sprint => Sprint.Project)
                .WithMany(Project => Project.ProjectSprints)
                .HasForeignKey(Sprint => Sprint.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<UserStory>()
                .HasOne(Story => Story.Sprint)
                .WithMany(Sprint => Sprint.UserStories)
                .HasForeignKey(Story => Story.SprintId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Project>()
                .HasOne(Project => Project.Owner)
                .WithMany()
                .HasForeignKey(Project => Project.OwnerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<ProjectAppUser>()
                .HasKey(PA => new { PA.ProjectId, PA.AppUserId });

            builder.Entity<ProjectAppUser>()
                .HasOne(PA => PA.Project)
                .WithMany(Project => Project.ProjectUsers)
                .HasForeignKey(PA => PA.ProjectId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<ProjectAppUser>()
                .HasOne(PA => PA.User)
                .WithMany(User => User.WorkingProjects)
                .HasForeignKey(PA => PA.AppUserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<AppUser>().HasData(admin);
            builder.Entity<Project>().HasData(TestProject);
            builder.Entity<Sprint>().HasData(TestSprint, TestSprint1, TestSprint2);
            builder.Entity<UserStory>().HasData(TestStory, TestStory1, TestStory2);
            builder.Entity<ProjectAppUser>().HasData(PA1);



            var adminr = new IdentityRole()
            { Id = "1", Name = "Admin", NormalizedName = "ADMIN" };
            var scrummaster = new IdentityRole()
            { Id = "2", Name = "Scrum_Master", NormalizedName = "SCRUM_MASTER" };
            var developr = new IdentityRole()
            { Id = "3", Name = "Developer", NormalizedName = "DEVELOPER" };
            builder.Entity<IdentityRole>().HasData(adminr,scrummaster, developr);

            var fadmin = new IdentityUserRole<string>()
            { RoleId = "1", UserId = admin.Id};
            builder.Entity<IdentityUserRole<string>>().HasData(fadmin);


            base.OnModelCreating(builder);
        }
    }
}
