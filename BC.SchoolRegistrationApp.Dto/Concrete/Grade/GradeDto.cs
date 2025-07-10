using BC.SchoolRegistrationApp.Dto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.Dto.Concrete.Grade
{
    public class GradeDto :IDto
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string LessonName { get; set; }
        public string ExamName { get; set; }
        public double Score { get; set; }
    }
}
