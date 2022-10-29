using AYZ8R9_SOF_202231.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AYZ8R9_SOF_202231.Repository
{
    public class UserStoryRepository : Repository<UserStory>, IUserStoryRepository
    {
        public UserStoryRepository(IdentityDbContext ctx) : base(ctx)
        {
        }

        public override void Change(UserStory NewStory)
        {
            var userStory = GetOne(NewStory.UserStoryId);
            userStory.UserStoryName = NewStory.UserStoryName;
            userStory.UserStoryDescription = NewStory.UserStoryDescription;
            userStory.Status = NewStory.Status;
            userStory.UserStoryPriority = NewStory.UserStoryPriority;
            ctx.SaveChanges();
        }

        public override void Create(UserStory NewStory)
        {
            ctx.Add(NewStory);
            ctx.SaveChanges();
        }

        public override void Delete(string id)
        {
            var userStory = GetOne(id);
            ctx.Remove(userStory);
            ctx.SaveChanges();
        }

        public override UserStory GetOne(string id)
        {
            return GetAll().FirstOrDefault(UserStory => UserStory.UserStoryId == id);
        }
    }
}
