using BC.SchoolRegistrationApp.BL.Service;
using BC.SchoolRegistrationApp.DAL.Uow;
using BC.SchoolRegistrationApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.BL.Manager
{
    public class LessonHourManager : GenericManager<LessonHour>, ILessonHourService
    {
        public LessonHourManager(IUow uow) : base(uow)
        {
        }
    }
}
