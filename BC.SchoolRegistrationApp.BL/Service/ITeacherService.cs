using BC.SchoolRegistrationApp.Dto.Concrete.Teacher;
using BC.SchoolRegistrationApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.BL.Service
{
    public interface ITeacherService : IGenericServiceDto<Teacher, TeacherDto, TeacherAddDto, TeacherUpdateDto, TeacherListDto, TeacherDetailDto>
    {
        //List<TeacherDto> GetAllTeachers(Expression<Func<Teacher, bool>> filter = null);
    }
}
