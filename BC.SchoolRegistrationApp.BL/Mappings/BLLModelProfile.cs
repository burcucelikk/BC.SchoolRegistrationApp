using AutoMapper;
using BC.SchoolRegistrationApp.Dto.Concrete;
using BC.SchoolRegistrationApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.BL.Mappings
{
    public class BLLModelProfile : Profile
    {
        public BLLModelProfile()
        {
            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<Teacher,TeacherDto>().ReverseMap();
            //CreateMap<Class,ClassDto>().ReverseMap();
            //CreateMap<ClassLesson,ClassLessonDto>().ReverseMap();
            //CreateMap<Lesson,LessonDto>().ReverseMap();
            //CreateMap<LessonSchedule,LessonScheduleDto>().ReverseMap();

        }
    }
}
