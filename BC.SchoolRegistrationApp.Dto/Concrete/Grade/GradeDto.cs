﻿using BC.SchoolRegistrationApp.Dto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.Dto.Concrete.Grade
{
    public class GradeDto :IDto
    {
        public int Id { get; set; }
        public string StudentFullName { get; set; }
        public string Lesson { get; set; }
        public string Exam { get; set; }
        public double Score { get; set; }
    }
}
