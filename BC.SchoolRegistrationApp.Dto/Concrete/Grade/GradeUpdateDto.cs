using BC.SchoolRegistrationApp.Dto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.Dto.Concrete.Grade
{
    public class GradeUpdateDto:IDto
    {
        public int Id { get; set; }
        public int? StudentID { get; set; }
        public int? LessonID { get; set; }
        public int? ExamID { get; set; }
        public double? Score { get; set; }
    }
}
