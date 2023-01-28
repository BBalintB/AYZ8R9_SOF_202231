using AYZ8R9_SOF_202231.Model;

namespace AYZ8R9_SOF_202231.Logic
{
    public interface IUserStoryLogic
    {
        void AddToSprint(string sprintID, string storyID);
        void ChangeStory(UserStory newStory);
        void CreateStory(UserStory newStory);
        void DeleteStory(string id);
        IEnumerable<UserStory> GetAllStories();
        UserStory GetOneStory(string id);
        void RemoveFromSprint(string storyID);
    }
}