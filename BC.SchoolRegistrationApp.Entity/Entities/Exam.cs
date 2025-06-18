using BC.SchoolRegistrationApp.Entity.Abstracts;
using BC.SchoolRegistrationApp.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.Entity.Entities
{
    public class Exam :IEntity
    {
        public int ID { get; set; }
        public ExamType ExamType { get; set; }
        public int LessonID { get; set; }
        public Lesson Lesson { get; set; }
        public ICollection<Grade> Grades { get; set; }
    }
}
