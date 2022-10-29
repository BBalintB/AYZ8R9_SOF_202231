using AYZ8R9_SOF_202231.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AYZ8R9_SOF_202231.Repository
{
    public class ProjectRepository : Repository<Project>, IProjectRepository
    {
        public ProjectRepository(IdentityDbContext ctx) : base(ctx)
        {
        }

        public override void Change(Project NewProject)
        {
            var user = GetOne(NewProject.ProjectId);
            user.ProjectName = NewProject.ProjectName;
            ctx.SaveChanges();
        }

        public override void Create(Project NewProject)
        {
            ctx.Add(NewProject);
            ctx.SaveChanges();
        }

        public override void Delete(string id)
        {
            var project = GetOne(id);
            ctx.Remove(project);
            ctx.SaveChanges();
        }

        public override Project GetOne(string id)
        {
            return GetAll().FirstOrDefault(Project => Project.ProjectId == id);
        }
    }
}
