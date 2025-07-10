using BC.SchoolRegistrationApp.Dto.Base;
using BC.SchoolRegistrationApp.Dto.Concrete.Teacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.Dto.Concrete.Lesson
{
    public class LessonDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int WeeklyHour { get; set; }
    }
}
