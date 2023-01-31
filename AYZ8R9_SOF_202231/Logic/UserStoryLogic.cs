using AYZ8R9_SOF_202231.Logic.Exceptions;
using AYZ8R9_SOF_202231.Model;
using AYZ8R9_SOF_202231.Repository;
using System.Collections.Immutable;

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
                userStoryRepo.Change(newStory);
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
            var xy = userStoryRepo.GetAll();
            return xy;
        }

        public void AddToSprint(string sprintID, string storyID)
        {
            if (sprintID == null)
            {
                throw new ItemDoesNotExistException("The sprint id cant be null");
            }
            var story = GetOneStory(storyID);
            story.SprintId = sprintID;
            ChangeStory(story);
        }

        public void RemoveFromSprint(string storyID)
        {
            var story = GetOneStory(storyID);
            story.SprintId = null;
            story.UserId = null;
            ChangeStory(story);
        }
    }
}
