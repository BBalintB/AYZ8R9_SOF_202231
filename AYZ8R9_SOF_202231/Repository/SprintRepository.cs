using AYZ8R9_SOF_202231.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AYZ8R9_SOF_202231.Repository
{
    public class SprintRepository : Repository<Sprint>, ISprintRepository
    {
        public SprintRepository(IdentityDbContext ctx) : base(ctx)
        {
        }

        public override void Change(Sprint NewSprint)
        {
            var sprint = GetOne(NewSprint.SprintId);
            sprint.SprintName = NewSprint.SprintName;
            sprint.SprintDueDate = NewSprint.SprintDueDate;
            ctx.SaveChanges();
        }

        public override void Create(Sprint NewSprint)
        {
            ctx.Add(NewSprint);
            ctx.SaveChanges();
        }

        public override void Delete(string id)
        {
            var sprint = GetOne(id);
            ctx.Remove(sprint);
            ctx.SaveChanges();
        }

        public override Sprint GetOne(string id)
        {
            return GetAll().FirstOrDefault(Sprint => Sprint.SprintId == id);
        }
    }
}
