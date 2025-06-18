using BC.SchoolRegistrationApp.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.Entity.Entities
{
    public class Grade :IEntity
    {
        public int ID { get; set; }
        public int StudentID { get; set; }
        public Student Student { get; set; }
        public int LessonID { get; set; }
        public Lesson Lesson { get; set; }
        public int ExamID { get; set; }
        public Exam Exam { get; set; }
        public double Score { get; set; }
    }
}
