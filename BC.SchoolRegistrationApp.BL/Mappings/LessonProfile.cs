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
            CreateMap<Lesson, LessonDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ID))
                .ReverseMap();

            CreateMap<Lesson, LessonListDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ID));

            CreateMap<Lesson, LessonDetailDto>();

            CreateMap<LessonAddDto, Lesson>();

            CreateMap<LessonUpdateDto,Lesson>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Id))
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ID));

            
        }
    }    
}
