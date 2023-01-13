using AYZ8R9_SOF_202231.Logic.Exceptions;
using AYZ8R9_SOF_202231.Model;
using AYZ8R9_SOF_202231.Repository;

namespace AYZ8R9_SOF_202231.Logic
{
    public class ProjectLogic : IProjectLogic
    {
        IProjectRepository projectRepository;

        public ProjectLogic(IProjectRepository projectRepository)
        {
            this.projectRepository = projectRepository;
        }

        public void ChangeProject(Project newProject)
        {
            var user = GetOneProject(newProject.ProjectId);
            if (user != null)
            {
                projectRepository.Change(user);
            }
            else
            {
                throw new ItemDoesNotExistException("The user does not exist!");
            }
        }

        public void CreateProject(Project newProject)
        {

            if (IsTheProjectExist(newProject))
            {
                projectRepository.Create(newProject);
            }
            else
            {
                throw new ItemAlreadyExistException("The user is already exist!");
            }

        }

        public void DeleteProject(string id)
        {
            var user = GetOneProject(id);
            if (user != null)
            {
                projectRepository.Delete(id);
            }
            else
            {
                throw new ItemDoesNotExistException("The user does not exist!");
            }

        }

        public Project GetOneProject(string id)
        {
            var user = GetAllProjects().FirstOrDefault(x => x.ProjectId == id);
            if (user != null)
            {
                return projectRepository.GetOne(id);
            }
            throw new ItemDoesNotExistException("The user id was wrong!");
        }

        public IEnumerable<Project> GetAllProjects()
        {
            return projectRepository.GetAll();
        }


        #region Validation
        private bool IsTheProjectExist(Project project)
        {
            var user = GetAllProjects().FirstOrDefault(Project => Project.ProjectName == project.ProjectName && Project.Owner.UserName == project.Owner.UserName);
            return user == null ? true : false;
        }
        #endregion
    }
}
