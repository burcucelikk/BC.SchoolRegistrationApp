using BC.SchoolRegistrationApp.Entity.Abstracts;
using BC.SchoolRegistrationApp.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.Entity.Entities
{
    public class LessonSchedule :IEntity
    {
        public int ID { get; set; }
        public WeekDays Day { get; set; }
        public int LessonHourID { get; set; }
        public LessonHour LessonHour { get; set; }
        public int LessonID { get; set; }
        public Lesson Lesson { get; set; }
        public int TeacherID { get; set; }
        public Teacher Teacher { get; set; }
        public int ClassID { get; set; }
        public Class Class { get; set; }
    }
}
