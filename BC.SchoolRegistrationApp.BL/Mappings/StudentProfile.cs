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
            .ReverseMap()
            .ForMember(dest=>dest.ID, opt=>opt.MapFrom(src=>src.Id));

            CreateMap<Student, StudentListDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.ClassName, opt => opt.MapFrom(src => src.Class.Name));

            CreateMap<Student, StudentDetailDto>()
                .ForMember(dest => dest.ClassName, opt => opt.MapFrom(src => src.Class.Name));

            CreateMap<StudentAddDto, Student>();

            CreateMap<StudentUpdateDto, Student>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Id))
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ID));
        }
    }
}
