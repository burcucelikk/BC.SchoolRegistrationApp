using BC.SchoolRegistrationApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.BL.Service
{
    public interface IStudentService : IGenericService<Student>
    {
        List<Student> GetStudentsByClassName(string className);
    }
}
