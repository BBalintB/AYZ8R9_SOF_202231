using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AYZ8R9_SOF_202231.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected IdentityDbContext ctx;

        protected Repository(IdentityDbContext ctx)
        {
            this.ctx = ctx;
        }

        public abstract void Create(T NewEntity);
        public abstract void Change(T NewEntity);

        public abstract void Delete(string id);

        public IQueryable<T> GetAll()
        {
            return ctx.Set<T>();
        }

        public abstract T GetOne(string id);
    }
}
