using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Databases.Entities;

namespace DatingApp.API.Services
{
    public interface IUserService
    {
        List<User> GetUsers();
        User? GetUserById(int id);
        User? GetUserByUsername(string username);

        void CreateUSer(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
    }
}