using BC.SchoolRegistrationApp.Dto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.Dto.Concrete.Lesson
{
    public class LessonDetailDto :IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int WeeklyHour { get; set; }

        public List<string> TeacherNames { get; set; }
        public List<string> ClassNames { get; set; }
    }
}
