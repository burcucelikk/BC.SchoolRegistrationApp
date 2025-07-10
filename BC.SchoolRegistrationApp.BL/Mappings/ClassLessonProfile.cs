using AutoMapper;
using BC.SchoolRegistrationApp.Dto.Concrete.ClassLesson;
using BC.SchoolRegistrationApp.Entity.Entities;
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
            CreateMap<ClassLesson, ClassLessonDto>()
                .ForMember(dest => dest.ClassName, opt => opt.MapFrom(src => src.Class.Name))
                .ForMember(dest => dest.LessonName, opt => opt.MapFrom(src => src.Lesson.Name))
                .ForMember(dest => dest.TeacherName, opt => opt.MapFrom(src => src.Teacher.Name + " " + src.Teacher.Surname));
        }
    }
}
