using AYZ8R9_SOF_202231.Model;

namespace AYZ8R9_SOF_202231.Logic
{
    public interface IAppUserLogic
    {
        void ChangeUser(AppUser NewAppUser);
        void CreateUser(AppUser NewAppUser);
        void DeleteUser(string id);
        IEnumerable<AppUser> GetAllUsers();
        AppUser GetOneUser(string id);
    }
}