using BC.SchoolRegistrationApp.Dto.Concrete.Grade;
using BC.SchoolRegistrationApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.BL.Service
{
    public interface IGradeService :IGenericServiceDto<Grade, GradeDto, GradeAddDto, GradeUpdateDto, GradeListDto, GradeDetailDto> 
    {
        List<GradeDetailDto> GetGradesByStudentId(int studentId);
    }
}
