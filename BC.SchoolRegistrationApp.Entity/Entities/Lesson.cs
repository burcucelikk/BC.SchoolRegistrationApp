using BC.SchoolRegistrationApp.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.Entity.Entities
{
    public class Lesson : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int WeeklyHour { get; set; }
        public ICollection<Exam> Exams { get; set; }
        public ICollection<Grade> Grades { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<ClassLesson> ClassLessons { get; set; }
    }
}
