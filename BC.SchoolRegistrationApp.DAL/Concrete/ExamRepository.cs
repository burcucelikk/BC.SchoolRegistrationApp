using BC.SchoolRegistrationApp.DAL.Abstract;
using BC.SchoolRegistrationApp.DAL.Context;
using BC.SchoolRegistrationApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.DAL.Concrete
{
    public class ExamRepository : GenericRepository<Exam>, IExamRepository
    {
        public ExamRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
