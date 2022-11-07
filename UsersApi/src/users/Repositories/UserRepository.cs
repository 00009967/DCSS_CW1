using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersApi.src.Data;
using UsersApi.src.users.Interfaces;
using UsersApi.src.users.Models;

namespace UsersApi.src.users.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(UsersApiContext usersApiContext)
            : base(usersApiContext)
        {
        }

        public IEnumerable<User> GetAllUsers()
        {
            return FindAll()
                .OrderBy(ow => ow.Name)
                .ToList();
        }

        public User GetUserById(int id)
        {
            return FindByCondition(user => user.Id.Equals(id)).FirstOrDefault();
        }

        public void CreateUser(User user) => Create(user);
        public void UpdateUser(User user) => Update(user);
        public void DeleteUser(User user) => Delete(user);
    }
}
