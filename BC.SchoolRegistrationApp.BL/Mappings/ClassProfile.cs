using AutoMapper;
using BC.SchoolRegistrationApp.Dto.Concrete.Class;
using BC.SchoolRegistrationApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.BL.Mappings
{
    public class ClassProfile : Profile
    {
        public ClassProfile()
        {
            CreateMap<Class, ClassDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ID));

            CreateMap<Class, ClassListDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ID));

            CreateMap<Class, ClassDetailDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ID));

            CreateMap<ClassAddDto, Class>();

            CreateMap<ClassUpdateDto, Class>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Id))
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ID));
        }
    }
}
