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
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.ClassName, opt => opt.MapFrom(src => src.Class.Name))
                .ReverseMap();

            CreateMap<Student, StudentListDto>()
                .ForMember(dest => dest.ClassName, opt => opt.MapFrom(src => src.Class.Name))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ID));

            CreateMap<Student, StudentDetailDto>()
                .ForMember(dest => dest.ClassName, opt => opt.MapFrom(src => src.Class.Name));

            CreateMap<StudentAddDto, Student>();

            CreateMap<Student, StudentUpdateDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ID))
                .ReverseMap()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Id));
        }
    }
}
