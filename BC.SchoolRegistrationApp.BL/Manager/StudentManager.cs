﻿using BC.SchoolRegistrationApp.BL.Service;
using BC.SchoolRegistrationApp.DAL.Abstract;
using BC.SchoolRegistrationApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BC.SchoolRegistrationApp.BL.Manager
{
    public class StudentManager : GenericManager<Student>, IStudentService
    {
        public StudentManager(IUow uow) : base(uow)
        {
          
        }
        public List<Student> GetStudentsByClassName(string className)
        {
            return _uow.studentRepository.GetStudentsByClassName(className);
        }
    }
}
