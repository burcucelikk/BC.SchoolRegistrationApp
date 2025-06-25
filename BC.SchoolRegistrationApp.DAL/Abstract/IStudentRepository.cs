using BC.SchoolRegistrationApp.Entity.Abstracts;
using BC.SchoolRegistrationApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.DAL.Abstract
{
    public interface IStudentRepository: IGenericRepository<Student>
    {
        List<Student> GetStudentsByClassName(string className);
    }
}
