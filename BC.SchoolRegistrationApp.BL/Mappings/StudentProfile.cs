using AutoMapper;
using BC.SchoolRegistrationApp.BL.Resolvers;
using BC.SchoolRegistrationApp.Dto.Concrete.Student;
using BC.SchoolRegistrationApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.BL.Mappings
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<Student, StudentDto>()
            .ForMember(dest => dest.Class, opt => opt.MapFrom(src => src.Class.Name))
            .ReverseMap();

            CreateMap<Student, StudentListDto>()
                .ForMember(dest => dest.Class, opt => opt.MapFrom(src => src.Class.Name));

            CreateMap<Student, StudentDetailDto>()
                .ForMember(dest => dest.Class, opt => opt.MapFrom(src => src.Class.Name));

            CreateMap<StudentAddDto, Student>();

            CreateMap<Student, StudentUpdateDto>().ReverseMap();
        }
    }
}
