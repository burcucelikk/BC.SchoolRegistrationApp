using AutoMapper;
using BC.SchoolRegistrationApp.BL.Service;
using BC.SchoolRegistrationApp.DAL.Abstract;
using BC.SchoolRegistrationApp.DAL.Concrete;
using BC.SchoolRegistrationApp.Dto.Concrete;
using BC.SchoolRegistrationApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.BL.Manager
{
    public class ClassManager : GenericManager<Class, ClassDto>, IClassService
    {
        private readonly IClassRepository _classRepository;
        public ClassManager(IUow uow, IMapper mapper) : base(uow, mapper)
        {
            _classRepository = uow.classRepository;
        }
        public List<string> GetClassNames() => _classRepository.GetQueryable().Select(x => x.Name).ToList();
        public int? GetClassIDByName(string className)
        { 
            var classEntity = _classRepository.GetQueryable().FirstOrDefault(x => x.Name == className);
            return classEntity?.ID;
        }
    }
}
