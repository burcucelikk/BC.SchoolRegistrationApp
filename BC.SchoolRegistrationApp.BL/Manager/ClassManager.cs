using BC.SchoolRegistrationApp.BL.Service;
using BC.SchoolRegistrationApp.DAL.Abstract;
using BC.SchoolRegistrationApp.DAL.Concrete;
using BC.SchoolRegistrationApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.BL.Manager
{
    public class ClassManager : GenericManager<Class>, IClassService
    {
        public ClassManager(IUow uow) : base(uow)
        {
        }
        public List<string> GetClassNames()=> _uow.classRepository.GetClassNames();

        public int GetIDByName(string className) => _uow.classRepository.GetIDByName(className);
    }
}
