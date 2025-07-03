using AutoMapper;
using BC.SchoolRegistrationApp.BL.Service;
using BC.SchoolRegistrationApp.DAL.Abstract;
using BC.SchoolRegistrationApp.Dto.Concrete;
using BC.SchoolRegistrationApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BC.SchoolRegistrationApp.BL.Manager
{
    public class StudentManager : GenericManager<Student, StudentDto>, IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentManager(IUow uow, IMapper mapper) : base(uow, mapper)
        {
            _studentRepository = uow.studentRepository;
        }
        #region LINQ Select Protection
        //public List<StudentDto> GetAllStudents(Expression<Func<Student, bool>> filter = null)
        //{
        //    return _studentRepository.GetQueryable()
        //        .Include(x => x.Class)
        //        .Select(x => new StudentDto
        //        {
        //            Id = x.ID,
        //            Name = x.Name,
        //            Surname = x.Surname,
        //            Number = x.Number,
        //            Photograph = x.Photograph,
        //            ClassName = x.Class.Name
        //        }).ToList();
        //}
        //public List<StudentDto> GetStudentsWithClassName(string className)
        //{
        //    return _studentRepository.GetQueryable()
        //        .Include(x => x.Class)
        //        .Where(x => x.Class.Name == className)
        //        .Select(x => new StudentDto
        //        {
        //            Id = x.ID,
        //            Name = x.Name,
        //            Surname = x.Surname,
        //            Number = x.Number,
        //            Photograph = x.Photograph,
        //            ClassName = x.Class.Name  //AutoMapper yerine LINQ select projection
        //        }).ToList();
        //}
        #endregion

        public override List<StudentDto> GetAll(Expression<Func<Student, bool>> filter = null)
        {
            var query= _studentRepository.GetQueryable().Include(x=>x.Class);
            if (filter != null)
                query = query.Where(filter);

            var entities = query.ToList();
            return _mapper.Map<List<StudentDto>>(entities);
        }
    }
}
