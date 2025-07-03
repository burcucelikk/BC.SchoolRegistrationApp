using AutoMapper;
using BC.SchoolRegistrationApp.BL.Resolvers;
using BC.SchoolRegistrationApp.Dto.Concrete;
using BC.SchoolRegistrationApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.BL.Mappings
{
    public class TeacherProfile :Profile
    {
        public TeacherProfile() 
        {
            CreateMap<Teacher,TeacherDto>()
                .ForMember(dest=>dest.LessonName, opt=>opt.MapFrom(src=>src.Lesson.Name));
            CreateMap<TeacherDto, Teacher>()
                .ForMember(dest => dest.Lesson, opt => opt.Ignore())
                .ForMember(dest => dest.LessonID, opt => opt.MapFrom<LessonNameToIDResolver>());
        }
    }
}
