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
        public LessonHour LessonHour { get; set; }
        public int ClassLessonID { get; set; }
        public  ClassLesson ClassLesson {  get; set; }
    }
}
