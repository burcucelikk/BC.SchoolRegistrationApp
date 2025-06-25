using BC.SchoolRegistrationApp.DAL.Abstract;
using BC.SchoolRegistrationApp.DAL.Context;
using BC.SchoolRegistrationApp.DAL.UnitOfWork;
using BC.SchoolRegistrationApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.DAL.Concrete
{
    public class ClassRepository : GenericRepository<Class>, IClassRepository
    {
        public ClassRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
        public List<string> GetClassNames() => GetAll().Select(x => x.Name).ToList();
        public int GetIDByName(string className) => GetAll().FirstOrDefault(x => x.Name == className).ID;
    }
}
