﻿using BC.SchoolRegistrationApp.Dto.Concrete;
using BC.SchoolRegistrationApp.Dto.Concrete.Student;
using BC.SchoolRegistrationApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.BL.Service
{
    public interface IStudentService : IGenericServiceDto<Student, StudentDto, StudentAddDto, StudentUpdateDto, StudentListDto, StudentDetailDto>
    {
        //List<StudentDto> GetAllStudents(Expression<Func<Student, bool>> filter = null);
        //List<StudentDto> GetStudentsWithClassName(string className);
    }
}
