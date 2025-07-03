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
        void Add(TDto dto);
        void Update(TDto dto);
        void Delete(TDto dto);
        TDto? GetById(int id);
        TDto? Get(Expression<Func<T, bool>> predicate);
        List<TDto> GetAll(Expression<Func<T, bool>> filter = null);
    }
}
