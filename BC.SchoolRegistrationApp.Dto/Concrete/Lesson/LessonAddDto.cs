using BC.SchoolRegistrationApp.Dto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.Dto.Concrete.Lesson
{
    public class LessonAddDto :IDto
    {
        public string Name { get; set; }
        public int WeeklyHour { get; set; }
    }
}
