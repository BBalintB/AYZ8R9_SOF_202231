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
            var project = GetOneProject(newProject.ProjectId);
            if (project != null)
            {
                projectRepository.Change(newProject);
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
                throw new ItemAlreadyExistException("The project is already exist!");
            }

        }

        public void DeleteProject(string id)
        {
            var project = GetOneProject(id);
            if (project != null)
            {
                projectRepository.Delete(id);
            }
            else
            {
                throw new ItemDoesNotExistException("The project does not exist!");
            }

        }

        public Project GetOneProject(string id)
        {
            var project = GetAllProjects().FirstOrDefault(x => x.ProjectId == id);
            if (project != null)
            {
                return projectRepository.GetOne(id);
            }
            throw new ItemDoesNotExistException("The project id was wrong!");
        }

        public IEnumerable<Project> GetAllProjects()
        {
            return projectRepository.GetAll();
        }


        #region Validation
        private bool IsTheProjectExist(Project project)
        {
            var proj = GetAllProjects().FirstOrDefault(Project => Project.ProjectName == project.ProjectName && Project.Owner.UserName == project.Owner.UserName);
            return proj == null ? true : false;
        }
        #endregion
    }
}
