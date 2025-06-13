using BC.SchoolRegistrationApp.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.BL.Service
{
    public interface IService<T> where T: class, IEntity
    {
        void Add(T entitiy);
        void Update(T entitiy);
        void Delete(T entitiy);
        T? GetById(int id);
        List<T> GetAll();
    }
}
