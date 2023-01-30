using AYZ8R9_SOF_202231.Logic.Exceptions;
using AYZ8R9_SOF_202231.Model;
using AYZ8R9_SOF_202231.Repository;
using Microsoft.Extensions.Primitives;

namespace AYZ8R9_SOF_202231.Logic
{
    public class ProjectAppUserLogic : IProjectAppUserLogic
    {
        IProjectAppUserRepository paRepo;

        public ProjectAppUserLogic(IProjectAppUserRepository paRepo)
        {
            this.paRepo = paRepo;
        }

        public void CreatePA(ProjectAppUser newPA)
        {
            if (newPA.Project.ProjectUsers.Count >= 10)
            {
                throw new ProjectAlreadyFullException("The project already has 10 member team!");
            }
            if (newPA.User.UserName == newPA.Project.Owner.UserName)
            {
                throw new ItemAlreadyExistException("The owner cant sign up for his own project!");
            }
            if (IsTheUserExist(newPA))
            {
                paRepo.Create(newPA);
            }
            else
            {
                throw new ItemAlreadyExistException("The connection is already exist between user and project!");
            }

        }

        public void DeletePA(string projectId,string userId)
        {
            var pa = GetAllPA().FirstOrDefault(ipa => ipa.AppUserId == userId && ipa.ProjectId == projectId);
            if (pa != null)
            {
                paRepo.Delete(pa.ConnectionId);
            }
            else
            {
                throw new ItemDoesNotExistException("The connection between user and project does not exist!");
            }

        }

        public ProjectAppUser GetOnePA(string id)
        {
            var user = GetAllPA().FirstOrDefault(x => x.ConnectionId == id);
            if (user != null)
            {
                return paRepo.GetOne(id);
            }
            throw new ItemDoesNotExistException("The connection id was wrong!");
        }

        public IEnumerable<ProjectAppUser> GetAllPA()
        {
            return paRepo.GetAll();
        }


        #region Validation
        private bool IsTheUserExist(ProjectAppUser pa)
        {
            var user = GetAllPA().FirstOrDefault(PA => PA.Project.ProjectName == pa.Project.ProjectName && PA.User.UserName == pa.User.UserName);
            return user == null ? true : false;
        }
        #endregion
    }
}
