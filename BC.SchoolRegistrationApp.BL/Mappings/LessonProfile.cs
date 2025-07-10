using AutoMapper;
using BC.SchoolRegistrationApp.Dto.Concrete;
using BC.SchoolRegistrationApp.Dto.Concrete.Lesson;
using BC.SchoolRegistrationApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.BL.Mappings
{
    public class LessonProfile :Profile
    {
        public LessonProfile() 
        {
            CreateMap<Lesson, LessonDto>();
            CreateMap<Lesson, LessonListDto>();
            CreateMap<Lesson, LessonAddDto>().ReverseMap();
            CreateMap<Lesson, LessonUpdateDto>().ReverseMap();

            CreateMap<Lesson, LessonDetailDto>()
                .ForMember(dest => dest.TeacherNames, opt => opt.MapFrom(src =>
                    src.Teachers.Select(t => t.Name + " " + t.Surname)))
                .ForMember(dest => dest.ClassNames, opt => opt.MapFrom(src =>
                    src.ClassLessons.Select(cl => cl.Class.Name)));
        }
    }
}
