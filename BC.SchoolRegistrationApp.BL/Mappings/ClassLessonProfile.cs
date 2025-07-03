using AutoMapper;
using BC.SchoolRegistrationApp.Dto.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.BL.Mappings
{
    public class ClassLessonProfile :Profile
    {
        public ClassLessonProfile() 
        { 
            CreateMap<ClassProfile,ClassLessonDto>().ReverseMap();
        }
    }
}
