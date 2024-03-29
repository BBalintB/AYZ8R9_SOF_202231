﻿using AYZ8R9_SOF_202231.Data;
using AYZ8R9_SOF_202231.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AYZ8R9_SOF_202231.Repository
{
    public class AppUserRepository : Repository<AppUser>, IAppUserRepository
    {
        public AppUserRepository(SCRUMDbContext ctx) : base(ctx)
        {
        }

        public override void Change(AppUser NewAppUser)
        {
            var user = GetOne(NewAppUser.Id);
            user.Email = NewAppUser.Email;
            user.FirstName = NewAppUser.FirstName;
            user.LastName = NewAppUser.LastName;
            user.UserName = NewAppUser.UserName;
            user.Email = NewAppUser.Email;
            user.PhotoData = NewAppUser.PhotoData;
            user.PhotoContentType = NewAppUser.PhotoContentType;
            ctx.SaveChanges();
        }

        public override void Create(AppUser NewAppUser)
        {
            ctx.Add(NewAppUser);
            ctx.SaveChanges();
        }

        public override void Delete(string id)
        {
            var user = GetOne(id);
            ctx.Remove(user);
            ctx.SaveChanges();
        }

        public override AppUser GetOne(string id)
        {
            return GetAll().FirstOrDefault(AppUser => AppUser.Id == id);
        }
    }
}
