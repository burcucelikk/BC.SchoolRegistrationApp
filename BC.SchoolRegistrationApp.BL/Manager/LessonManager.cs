using AutoMapper;
using BC.SchoolRegistrationApp.BL.Service;
using BC.SchoolRegistrationApp.DAL.Abstract;
using BC.SchoolRegistrationApp.Dto.Concrete.Lesson;
using BC.SchoolRegistrationApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.BL.Manager
{
    public class LessonManager : GenericManager<Lesson,LessonDto>, ILessonService
    {
        public LessonManager(IUow uow,IMapper mapper) : base(uow, mapper)
        {
        }
    }
}
