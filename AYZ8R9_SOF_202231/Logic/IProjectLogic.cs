using AYZ8R9_SOF_202231.Model;

namespace AYZ8R9_SOF_202231.Logic
{
    public interface IProjectLogic
    {
        void ChangeProject(Project newProject);
        void CreateProject(Project newProject);
        void DeleteProject(string id);
        IEnumerable<Project> GetAllProjects();
        Project GetOneProject(string id);
    }
}