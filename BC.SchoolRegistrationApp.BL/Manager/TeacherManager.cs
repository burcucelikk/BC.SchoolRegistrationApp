using AutoMapper;
using BC.SchoolRegistrationApp.BL.Service;
using BC.SchoolRegistrationApp.DAL.Abstract;
using BC.SchoolRegistrationApp.Dto.Concrete.Teacher;
using BC.SchoolRegistrationApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.BL.Manager
{
    public class TeacherManager : GenericManagerDto<Teacher, TeacherDto, TeacherAddDto, TeacherUpdateDto, TeacherListDto, TeacherDetailDto>, ITeacherService
    {
        private Dictionary<int, int> _teacherLessonHours = new();
        private Dictionary<int, int> _lessonHoursPerClass = new();
        private Dictionary<int, List<int>> _lessonTeachers = new();

        private readonly ITeacherRepository _teacherRepository;
        public TeacherManager(IUow uow,IMapper mapper) : base(uow,mapper)
        {
            _teacherRepository= uow.teacherRepository;
        }

        #region LINQ Select Protection

        //public List<TeacherDto> GetAllTeachers(Expression<Func<Teacher, bool>> filter = null)
        //{
        //    return _teacherRepository.GetQueryable()
        //        .Include(x=>x.Lesson)
        //        .Select(x=> new TeacherDto
        //        {
        //            Id= x.ID,
        //            Name= x.Name,
        //            Surname= x.Surname,
        //            LessonName= x.Lesson.Name
        //        }).ToList();
        //}

        #endregion

        //public override List<TeacherDto> GetAll(Expression<Func<Teacher, bool>> filter = null)
        //{
        //    IQueryable<Teacher> query = _teacherRepository.GetQueryable().Include(x=>x.Lesson);
        //    if(filter != null)
        //        query = query.Where(filter);

        //    var entities = query.ToList();
        //    return _mapper.Map<List<TeacherDto>>(entities);
        //}
    }
}
