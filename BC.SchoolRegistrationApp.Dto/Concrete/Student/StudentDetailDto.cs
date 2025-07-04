using BC.SchoolRegistrationApp.Dto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.Dto.Concrete.Student
{
    public class StudentDetailDto :IDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Number { get; set; }
        public int ClassName { get; set; }
        public string LessonName { get; set; }
        public List<double> Grades { get; set; }
        public bool IsPassed { get; set; }
    }
}
