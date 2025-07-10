using AutoMapper;
using BC.SchoolRegistrationApp.BL.Service;
using BC.SchoolRegistrationApp.DAL.Abstract;
using BC.SchoolRegistrationApp.DAL.Concrete;
using BC.SchoolRegistrationApp.DAL.UnitOfWork;
using BC.SchoolRegistrationApp.Dto.Concrete.Class;
using BC.SchoolRegistrationApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.BL.Manager
{
    public class ClassManager : GenericManagerDto<Class, ClassDto, ClassAddDto, ClassUpdateDto, ClassListDto, ClassDetailDto>, IClassService
    {
        private readonly IUow _uow;
        private readonly IMapper _mapper;
        private readonly IClassRepository _classRepository;
        public ClassManager(IUow uow, IMapper mapper) : base(uow, mapper)
        {
            _classRepository = uow.classRepository;
            _mapper = mapper;
            _uow = uow;
        }
        //public int? GetClassIDByName(string className)
        //{ 
        //    var classEntity = _classRepository.GetQueryable().FirstOrDefault(x => x.Name == className);
        //    return classEntity?.ID;
        //}
    }
}
