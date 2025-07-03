using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.Dto.Concrete
{
    public class StudentDetailDto
    {
        public StudentDto StudentInfo { get; set; }
        public List<GradeDetailDto> Grades { get; set; }
        public bool IsPassed { get; set; }
    }
}
