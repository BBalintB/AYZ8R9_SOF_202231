using AYZ8R9_SOF_202231.Model;

namespace AYZ8R9_SOF_202231.Logic
{
    public interface ISprintLogic
    {
        void ChangeSprint(Sprint newSprint);
        void CreateSprint(Sprint newSprint);
        void DeleteSprint(string id);
        IEnumerable<Sprint> GetAllSprints();
        Sprint GetOneSprint(string id);
    }
}