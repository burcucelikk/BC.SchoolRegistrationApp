using BC.SchoolRegistrationApp.Dto.Concrete.Class;
using BC.SchoolRegistrationApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.BL.Service
{
    public interface IClassService : IGenericServiceDto<Class, ClassDto, ClassAddDto, ClassUpdateDto, ClassListDto, ClassDetailDto>
    {
        //List<string> GetClassNames();
    }
}
