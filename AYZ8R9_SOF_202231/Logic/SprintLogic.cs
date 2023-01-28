using AYZ8R9_SOF_202231.Logic.Exceptions;
using AYZ8R9_SOF_202231.Model;
using AYZ8R9_SOF_202231.Repository;

namespace AYZ8R9_SOF_202231.Logic
{
    public class SprintLogic : ISprintLogic
    {
        ISprintRepository sprintRepo;

        public SprintLogic(ISprintRepository sprintRepo)
        {
            this.sprintRepo = sprintRepo;
        }

        public void ChangeSprint(Sprint newSprint)
        {
            var sprint = GetOneSprint(newSprint.SprintId);
            if (sprint != null)
            {
                sprintRepo.Change(newSprint);
            }
            else
            {
                throw new ItemDoesNotExistException("The sprint does not exist!");
            }
        }

        public void CreateSprint(Sprint newSprint)
        {
            sprintRepo.Create(newSprint);
        }

        public void DeleteSprint(string id)
        {
            var sprint = GetOneSprint(id);
            if (sprint != null)
            {
                sprintRepo.Delete(id);
            }
            else
            {
                throw new ItemDoesNotExistException("The sprint does not exist!");
            }

        }

        public Sprint GetOneSprint(string id)
        {
            var sprint = GetAllSprints().FirstOrDefault(x => x.SprintId == id);
            if (sprint != null)
            {
                return sprintRepo.GetOne(id);
            }
            throw new ItemDoesNotExistException("The sprint id was wrong!");
        }

        public IEnumerable<Sprint> GetAllSprints()
        {
            return sprintRepo.GetAll();
            
        }

        
    }
}
