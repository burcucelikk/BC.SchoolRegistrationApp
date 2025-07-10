using BC.SchoolRegistrationApp.Dto.Base;
using BC.SchoolRegistrationApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.Dto.Concrete.Grade
{
    public class GradeDetailDto : IDto
    {
        public int GradeId { get; set; }
        public string LessonName { get; set; }
        public string ExamType { get; set; }
        public double Score { get; set; }
    }
}
