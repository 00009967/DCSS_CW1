using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using UsersApi.src.Global.Interfaces;
using System.Linq;
using UsersApi.src.Data;
using System.Threading.Tasks;

namespace Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected UsersApiContext UsersApiContext { get; set; }
        public RepositoryBase(UsersApiContext usersApiContext)
        {
            UsersApiContext = usersApiContext;
        }
        public IQueryable<T> FindAll() => UsersApiContext.Set<T>().AsNoTracking();
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression) =>
            UsersApiContext.Set<T>().Where(expression).AsNoTracking();
        public void Create(T entity) => UsersApiContext.Set<T>().Add(entity);
        public void Update(T entity) => UsersApiContext.Set<T>().Update(entity);
        public void Delete(T entity) => UsersApiContext.Set<T>().Remove(entity);
    }
}
