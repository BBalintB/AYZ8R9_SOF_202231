using AYZ8R9_SOF_202231.Logic.Exceptions;
using AYZ8R9_SOF_202231.Model;
using AYZ8R9_SOF_202231.Repository;
using Microsoft.Extensions.Primitives;

namespace AYZ8R9_SOF_202231.Logic
{
    public class ProjectAppUserLogic : IProjectAppUserLogic
    {
        IProjectAppUserRepository paRepo;
        IAppUserLogic userLogic;
        IProjectLogic projectLogic;

        public ProjectAppUserLogic(IProjectAppUserRepository paRepo, IAppUserLogic userLogic, IProjectLogic projectLogic)
        {
            this.paRepo = paRepo;
            this.userLogic = userLogic;
            this.projectLogic = projectLogic;
        }

        public void CreatePA(ProjectAppUser newPA)
        {
            var user = userLogic.GetOneUser(newPA.AppUserId);
            var project = projectLogic.GetOneProject(newPA.ProjectId);
            if (project.ProjectUsers.Count >= 10)
            {
                throw new ProjectAlreadyFullException("The project already has 10 member team!");
            }
            if (user.UserName == project.Owner.UserName)
            {
                throw new ItemAlreadyExistException("The owner cant sign up for his own project!");
            }
            if (IsTheUserExist(user,project))
            {
                paRepo.Create(newPA);
            }
            else
            {
                throw new ItemAlreadyExistException("The connection is already exist between user and project!");
            }

        }

        public void DeletePA(string id)
        {
            var pa = GetAllPA().FirstOrDefault(ipa => ipa.ConnectionId == id);
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
        private bool IsTheUserExist(AppUser user, Project project)
        {
            var pa = GetAllPA().FirstOrDefault(PA => PA.Project.ProjectName == project.ProjectName && PA.User.UserName == user.UserName);
            return pa == null ? true : false;
        }
        #endregion
    }
}
