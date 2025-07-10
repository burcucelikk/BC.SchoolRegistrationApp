using AutoMapper;
using BC.SchoolRegistrationApp.DAL.Abstract;
using BC.SchoolRegistrationApp.Dto.Concrete.Teacher;
using BC.SchoolRegistrationApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.BL.Resolvers
{
    public class LessonNameToIDResolver : IValueResolver<TeacherDto, Teacher, int>
    {
        private readonly ILessonRepository _lessonRepository;

        public LessonNameToIDResolver(ILessonRepository lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }

        public int Resolve(TeacherDto source, Teacher destination, int destMember, ResolutionContext context)
        {
            var lessonEntity = _lessonRepository.GetQueryable().FirstOrDefault(x => x.Name == destination.Name); 
            return lessonEntity !=null ? lessonEntity.ID : 0;
        }
    }
}
