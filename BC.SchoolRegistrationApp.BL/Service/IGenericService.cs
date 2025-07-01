using BC.SchoolRegistrationApp.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.BL.Service
{
    public interface IGenericService<T, TDto> where T: class, IEntity
        where TDto : class
    {
        void Add(T entitiy);
        void Update(T entitiy);
        void Delete(T entitiy);
        T? GetById(int id);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
    }
}
