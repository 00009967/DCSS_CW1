using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersApi.src.Data;
using UsersApi.src.Global.Interfaces;
using UsersApi.src.users.Interfaces;
using UsersApi.src.users.Repositories;

namespace UsersApi.src.Global.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private UsersApiContext _usersApiContext;
        private IUserRepository _user;
        public IUserRepository User
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(_usersApiContext);
                }
                return _user;
            }
        }
        public RepositoryWrapper(UsersApiContext usersApiContext)
        {
            _usersApiContext = usersApiContext;
        }
        public void Save()
        {
            _usersApiContext.SaveChanges();
        }
    }
}
