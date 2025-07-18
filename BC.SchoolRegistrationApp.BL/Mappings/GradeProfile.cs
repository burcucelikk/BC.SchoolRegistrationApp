using AutoMapper;
using BC.SchoolRegistrationApp.Dto.Concrete.Grade;
using BC.SchoolRegistrationApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.BL.Mappings
{
    public class GradeProfile : Profile
    {
        public GradeProfile()
        {
            CreateMap<Grade,GradeDto>()
                .ForMember(dest=>dest.StudentFullName, opt=>opt.MapFrom(src=>src.Student.Name))
                .ForMember(dest => dest.Lesson, opt => opt.MapFrom(src => src.Lesson.Name))
                .ForMember(dest => dest.Exam, opt => opt.MapFrom(src => src.Exam.ExamType.ToString()))
                .ReverseMap();

            CreateMap<Grade, GradeListDto>()
                .ForMember(dest => dest.Exam, opt => opt.MapFrom(src => src.Exam.ExamType.ToString()))
                .ForMember(dest => dest.Lesson, opt => opt.MapFrom(src => src.Lesson.Name))
                .ForMember(dest => dest.StudentNumber, opt => opt.MapFrom(src => src.Student.Number))
                .ForMember(dest => dest.StudentFullName, opt => opt.MapFrom(src => string.Join(src.Student.Name,src.Student.Surname)));

            CreateMap<Grade, GradeDetailDto>()
                .ForMember(dest => dest.Lesson, opt => opt.MapFrom(src => src.Lesson.Name))
                .ForMember(dest => dest.Exam, opt => opt.MapFrom(src => src.Exam.ExamType.ToString()));

            CreateMap<GradeAddDto,Grade>();

            CreateMap<Grade,GradeUpdateDto>().ReverseMap();
        }
    }
}
