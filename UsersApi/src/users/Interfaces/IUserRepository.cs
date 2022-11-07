using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersApi.src.Global.Interfaces;
using UsersApi.src.users.Models;

namespace UsersApi.src.users.Interfaces
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
    }
}
