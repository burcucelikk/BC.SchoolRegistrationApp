using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BC.SchoolRegistrationApp.Entity.Abstracts
{
    public interface IGenericRepository<T> where T : class, IEntity
    {
        T? GetById(int id);
        T? Get(Expression<Func<T, bool>> predicate);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void DeleteById(int id);
        IQueryable<T> GetQueryable();
    }
}
