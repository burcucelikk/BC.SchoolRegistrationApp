using BC.SchoolRegistrationApp.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.DAL.Abstract
{
    public interface IUow
    {
        IClassRepository classRepository { get; }
        IStudentRepository studentRepository { get; }

        void SaveChanges();
        IGenericRepository<T> GetRepository<T>() where T: class, IEntity;
    }
}
