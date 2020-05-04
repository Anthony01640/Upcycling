using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpCycling.Data;
using UpCycling.Data.Entity;
using UpCycling.Service.Interface;

namespace UpCycling.Service.Implementation
{
    public class UserService : IUserService
    {
        public UserService(ApplicationDbContext context, RoleManager<IdentityRole> roleManager)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
            RoleManager = roleManager;
        }

        public ApplicationDbContext Context { get; }
        public RoleManager<IdentityRole> RoleManager { get; }


        public async Task CreateUser(string mail)
        {
            var newUser = new User
            {
                Mail = mail,
            };
            await Context.Utilisateur.AddAsync(newUser);
            await Context.SaveChangesAsync();
        }

        public User GetUser(int idUser)
        {
            return Context.Utilisateur.FirstOrDefault(w => w.Id == idUser);
        }

        public User GetUserByMail(string mail)
        {
            return Context.Utilisateur.FirstOrDefault(w => w.Mail == mail);
        }
    }
}
