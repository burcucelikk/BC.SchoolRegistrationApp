using BC.SchoolRegistrationApp.BL.Service;
using BC.SchoolRegistrationApp.DAL.Abstract;
using BC.SchoolRegistrationApp.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.BL.Manager
{
    public class GenericManager<T> :IGenericService<T> where T: class, IEntity
    {
        protected IUow _uow;
        public GenericManager(IUow uow)
        {
            _uow = uow;
        }
        
        public void Add(T entity)=> _uow.GetRepository<T>().Add(entity);
        public void Delete(T entity) => _uow.GetRepository<T>().Delete(entity);

        public List<T> GetAll()=> _uow.GetRepository<T>().GetAll();
        public T? GetById(int id)=> _uow.GetRepository<T>().GetById(id);

        public void Update(T entitiy)=> _uow.GetRepository<T>().Update(entitiy);
    }
}
