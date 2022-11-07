using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersApi.src.users.Interfaces;

namespace UsersApi.src.Global.Interfaces
{
    public interface IRepositoryWrapper
    {
        IUserRepository User { get; }
        void Save();
    }
}
