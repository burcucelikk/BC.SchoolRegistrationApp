using BC.SchoolRegistrationApp.Dto.Concrete;
using BC.SchoolRegistrationApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.BL.Service
{
    public interface IClassService : IGenericService<Class, ClassDto>
    {
        List<string> GetClassNames();
        int? GetClassIDByName(string className);
    }
}
