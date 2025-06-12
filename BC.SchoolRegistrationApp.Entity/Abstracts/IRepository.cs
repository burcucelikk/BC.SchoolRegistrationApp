using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.Entity.Abstracts
{
    public interface IRepository<T> where T:class, IEntity
    {
        T? GetById(int id);
        T? Get(Expression<Func<T, bool>> predicate);
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Add(T entity);
        T Update(T entity);
        T Delete(int id);
        IQueryable<T> GetQueryable();

    }
}
