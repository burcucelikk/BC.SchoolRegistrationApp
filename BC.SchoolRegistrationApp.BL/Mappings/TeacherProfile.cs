using AutoMapper;
using BC.SchoolRegistrationApp.BL.Resolvers;
using BC.SchoolRegistrationApp.Dto.Concrete.Teacher;
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
            CreateMap<Teacher, TeacherDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.LessonName, opt => opt.MapFrom(src => src.Lesson.Name))
                .ReverseMap();

            CreateMap<Teacher, TeacherListDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.LessonName, opt => opt.MapFrom(src => src.Lesson.Name));

            CreateMap<Teacher, TeacherDetailDto>()
                .ForMember(dest => dest.LessonName, opt => opt.MapFrom(src => src.Lesson.Name))
                .ForMember(dest => dest.ClassNames, opt => opt.MapFrom(src => src.ClassLessons.Select(cl => cl.Class.Name)));

            CreateMap<TeacherAddDto, Teacher>();

            CreateMap<TeacherUpdateDto, Teacher>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Id))
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ID));
        }
    }
}
