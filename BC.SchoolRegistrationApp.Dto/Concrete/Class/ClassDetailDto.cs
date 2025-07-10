using BC.SchoolRegistrationApp.Dto.Base;
using BC.SchoolRegistrationApp.Dto.Concrete.ClassLesson;
using BC.SchoolRegistrationApp.Dto.Concrete.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.Dto.Concrete.Class
{
    public class ClassDetailDto :IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<StudentDto> Students { get; set; }
        public List<ClassLessonDto> ClassLessons { get; set; }
    }
}
