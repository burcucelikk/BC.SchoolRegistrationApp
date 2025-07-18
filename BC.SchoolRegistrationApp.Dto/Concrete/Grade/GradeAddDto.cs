using BC.SchoolRegistrationApp.Dto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.Dto.Concrete.Grade
{
    public class GradeAddDto :IDto
    {
        public int StudentId { get; set; }
        public int LessonId { get; set; }
        public int ExamId { get; set; }
        public double Score { get; set; }
    }
}
