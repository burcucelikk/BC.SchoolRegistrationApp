
using BC.SchoolRegistrationApp.Dto.Concrete.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DevExpress.XtraPrinting.Native.ExportOptionsPropertiesNames;

namespace BC.SchoolRegistrationApp.UI.Helpers
{
    public static class DtoHelper
    {
        public static StudentUpdateDto CreateStudentUpdateDtoFromDto(StudentDto dto)
        {
            return new StudentUpdateDto
            {
                Id = dto.Id,
                Name = dto.Name,
                Surname = dto.Surname,
                Number = dto.Number,
                Photograph = dto.Photograph,
                ClassName = dto.ClassName
            };
        }
        public static StudentAddDto CreateStudentAddDtoFromDto(string name, string surname, string number, string photograph, string className)
        {
            return new StudentAddDto
            {
                Name = name,
                Surname = surname,
                Number = number,
                Photograph = photograph,
                ClassName = className
            };
        }
    }
}
