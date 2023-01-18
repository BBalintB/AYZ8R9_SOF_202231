using AYZ8R9_SOF_202231.Data;
using AYZ8R9_SOF_202231.Model;

namespace AYZ8R9_SOF_202231.Repository
{
    public class ProjectAppUserRepository : Repository<ProjectAppUser>, IProjectAppUserRepository
    {
        public ProjectAppUserRepository(SCRUMDbContext ctx) : base(ctx)
        {
        }

        public override void Change(ProjectAppUser newPA)
        {
            throw new NotImplementedException();
        }

        public override void Create(ProjectAppUser newPA)
        {
            ctx.Add(newPA);
            ctx.SaveChanges();
        }

        public override void Delete(string id)
        {
            var pa = GetOne(id);
            ctx.Remove(pa);
            ctx.SaveChanges();
        }

        public override ProjectAppUser GetOne(string id)
        {
            return GetAll().FirstOrDefault(PA => PA.ConnectionId == id);
        }

        public IQueryable<ProjectAppUser> GetAll()
        {
            return base.GetAll();
        }
    }
}
