using AutoMapper;
using BC.SchoolRegistrationApp.Dto.Concrete.Exam;
using BC.SchoolRegistrationApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.BL.Mappings
{
    public class ExamProfile :Profile
    {
        public ExamProfile()
        {
            CreateMap<Exam, ExamDto>().ReverseMap();
        }
    }
}
