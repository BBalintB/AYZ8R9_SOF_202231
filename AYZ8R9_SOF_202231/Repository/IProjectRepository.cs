using AYZ8R9_SOF_202231.Model;

namespace AYZ8R9_SOF_202231.Repository
{
    public interface IProjectRepository : IRepository<Project>
    {
        void Change(Project NewProject);
        void Create(Project NewProject);
        void Delete(string id);
        Project GetOne(string id);
    }
}