using AYZ8R9_SOF_202231.Logic.Exceptions;
using AYZ8R9_SOF_202231.Model;
using AYZ8R9_SOF_202231.Repository;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AYZ8R9_SOF_202231.Logic
{
    public class AppUserLogic : IAppUserLogic
    {
        IAppUserRepository userRepo;

        public AppUserLogic(IAppUserRepository userRepo)
        {
            this.userRepo = userRepo;
        }

        public void ChangeUser(AppUser newAppUser)
        {
            var user = GetOneUser(newAppUser.Id);
            if (user != null)
            {
                userRepo.Change(newAppUser);
            }
            else
            {
                throw new ItemDoesNotExistException("The user does not exist!");
            }
        }

        public void CreateUser(AppUser newAppUser)
        {

            if (IsTheUserExist(newAppUser))
            {
                userRepo.Create(newAppUser);
            }
            else
            {
                throw new ItemAlreadyExistException("The user is already exist!");
            }

        }

        public void DeleteUser(string id)
        {
            var user = GetOneUser(id);
            if (user != null)
            {
                userRepo.Delete(id);
            }
            else
            {
                throw new ItemDoesNotExistException("The user does not exist!");
            }

        }

        public AppUser GetOneUser(string id)
        {
            var user = GetAllUsers().FirstOrDefault(x=> x.Id == id);
            if (user != null)
            {
                return userRepo.GetOne(id);
            }
            throw new ItemDoesNotExistException("The user id was wrong!");
        }

        public IEnumerable<AppUser> GetAllUsers()
        {
            return userRepo.GetAll();
        }


        #region Validation
        private bool IsTheUserExist(AppUser AppUser)
        {
            var user = GetAllUsers().FirstOrDefault(User => User.Email == AppUser.Email || User.UserName == AppUser.UserName);
            return user == null ? true : false;
        }
        #endregion
    }
}
