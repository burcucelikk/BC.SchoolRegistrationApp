﻿using BC.SchoolRegistrationApp.Dto.Base;
using BC.SchoolRegistrationApp.Dto.Concrete.Grade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.Dto.Concrete.Student
{
    public class StudentDetailDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Number { get; set; }
        public string? Photograph { get; set; }
        public string ClassName { get; set; }
        public bool IsPassed { get; set; }
    }
}
