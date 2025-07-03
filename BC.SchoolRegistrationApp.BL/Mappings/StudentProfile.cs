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
    public class StudentProfile :Profile
    {
        public StudentProfile() 
        {
            CreateMap<Student, StudentDto>()
                .ForMember(dest => dest.ClassName, opt => opt.MapFrom(src => src.Class.Name));
            CreateMap<StudentDto, Student>()
                .ForMember(dest => dest.Class, opt => opt.Ignore())
                .ForMember(dest => dest.ClassID, opt => opt.MapFrom<ClassNameToIDResolver>());
            CreateMap<Student,StudentDetailDto>().ReverseMap();
        }
    }
}
