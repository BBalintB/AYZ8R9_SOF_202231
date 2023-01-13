using AYZ8R9_SOF_202231.Model;

namespace AYZ8R9_SOF_202231.Repository
{
    public interface ISprintRepository:IRepository<Sprint>
    {
        void Change(Sprint NewSprint);
        void Create(Sprint NewSprint);
        void Delete(string id);
        Sprint GetOne(string id);
    }
}