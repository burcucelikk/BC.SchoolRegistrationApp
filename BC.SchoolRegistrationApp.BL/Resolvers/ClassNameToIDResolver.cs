using AutoMapper;
using BC.SchoolRegistrationApp.DAL.Abstract;
using BC.SchoolRegistrationApp.Dto.Concrete;
using BC.SchoolRegistrationApp.Dto.Concrete.Student;
using BC.SchoolRegistrationApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.BL.Resolvers
{
    public class ClassNameToIDResolver : IValueResolver<StudentDto, Student, int>
    {
        private readonly IClassRepository _classRepository;

        public ClassNameToIDResolver(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }

        public int Resolve(StudentDto source, Student destination, int destMember, ResolutionContext context)
        {
            var classEntity = _classRepository.GetQueryable().FirstOrDefault(x => x.Name == source.ClassName);
            return classEntity!= null ? classEntity.ID : 0;
        }
    }

}
