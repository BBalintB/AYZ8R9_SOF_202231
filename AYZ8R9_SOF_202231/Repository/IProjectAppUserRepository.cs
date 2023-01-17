using AYZ8R9_SOF_202231.Model;

namespace AYZ8R9_SOF_202231.Repository
{
    public interface IProjectAppUserRepository
    {
        void Change(ProjectAppUser newPA);
        void Create(ProjectAppUser newPA);
        void Delete(string id);
        ProjectAppUser GetOne(string id);
        IQueryable<ProjectAppUser> GetAll();
    }
}