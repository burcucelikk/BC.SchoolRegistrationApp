using AutoMapper;
using BC.SchoolRegistrationApp.BL.Service;
using BC.SchoolRegistrationApp.DAL.Abstract;
using BC.SchoolRegistrationApp.Dto.Concrete;
using BC.SchoolRegistrationApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.BL.Manager
{
    public class TeacherManager : GenericManager<Teacher, TeacherDto>, ITeacherService
    {
        private Dictionary<int, int> _teacherLessonHours = new();
        private Dictionary<int, int> _lessonHoursPerClass = new();
        private Dictionary<int, List<int>> _lessonTeachers = new();
        public TeacherManager(IUow uow,IMapper mapper) : base(uow,mapper)
        {
            var teachers = uow.GetRepository<Teacher>().GetQueryable().ToList();
        }
        public void Initialize(List<Teacher> teachers)
        {

        }
    }
}
