﻿using BC.SchoolRegistrationApp.Dto.Base;
using BC.SchoolRegistrationApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.Dto.Concrete.ClassLesson
{
    public class ClassLessonDto :IDto
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public string LessonName { get; set; }
        public string TeacherName { get; set; }
    }
}
