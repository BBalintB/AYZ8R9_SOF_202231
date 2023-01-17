using AYZ8R9_SOF_202231.Logic.Exceptions;
using AYZ8R9_SOF_202231.Model;
using AYZ8R9_SOF_202231.Repository;

namespace AYZ8R9_SOF_202231.Logic
{
    public class UserStoryLogic : IUserStoryLogic
    {
        IUserStoryRepository userStoryRepo;

        public UserStoryLogic(IUserStoryRepository userStoryRepo)
        {
            this.userStoryRepo = userStoryRepo;
        }

        public void ChangeStory(UserStory newStory)
        {
            var story = GetOneStory(newStory.UserStoryId);
            if (story != null)
            {
                userStoryRepo.Change(story);
            }
            else
            {
                throw new ItemDoesNotExistException("The story does not exist!");
            }
        }

        public void CreateStory(UserStory newStory)
        {
            userStoryRepo.Create(newStory);
        }

        public void DeleteStory(string id)
        {
            var sprint = GetOneStory(id);
            if (sprint != null)
            {
                userStoryRepo.Delete(id);
            }
            else
            {
                throw new ItemDoesNotExistException("The story does not exist!");
            }

        }

        public UserStory GetOneStory(string id)
        {
            var sprint = GetAllStories().FirstOrDefault(x => x.UserStoryId == id);
            if (sprint != null)
            {
                return userStoryRepo.GetOne(id);
            }
            throw new ItemDoesNotExistException("The story id was wrong!");
        }

        public IEnumerable<UserStory> GetAllStories()
        {
            return userStoryRepo.GetAll();
        }
    }
}
