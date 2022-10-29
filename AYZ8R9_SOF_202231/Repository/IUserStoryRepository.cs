using AYZ8R9_SOF_202231.Model;

namespace AYZ8R9_SOF_202231.Repository
{
    public interface IUserStoryRepository:IRepository<UserStory>
    {
        void Change(UserStory NewStory);
        void Create(UserStory NewStory);
        void Delete(string id);
        UserStory GetOne(string id);
    }
}