using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpCycling.Data.Entity;

namespace UpCycling.Service.Interface
{
    public interface IUserService
    {
        Task CreateUser(string mail);

        User GetUser(int idUser);

        User GetUserByMail(string mail);
    }
}
