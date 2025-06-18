using BC.SchoolRegistrationApp.DAL.Abstract;
using BC.SchoolRegistrationApp.DAL.Concrete;
using BC.SchoolRegistrationApp.DAL.Context;
using BC.SchoolRegistrationApp.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.DAL.UnitOfWork
{
    public class Uow : IUow
    {
        private readonly AppDbContext _context;
        public Uow(AppDbContext context)
        {
            _context = context;
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        IGenericRepository<T> IUow.GetRepository<T>()
        {
            return new GenericRepository<T>(_context);
        }
    }
}
