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
        private IClassRepository _classRepository;
        private IStudentRepository _studentRepository;
        private IGradeRepository _gradeRepository;
        private ITeacherRepository _teacherRepository;
        public Uow(AppDbContext context)
        {
            _context = context;
        }

        public IClassRepository classRepository => _classRepository ??= new ClassRepository(_context);
        public IGradeRepository gradeRepository => _gradeRepository ??= new GradeRepository(_context);
        public IStudentRepository studentRepository => _studentRepository ??= new StudentRepository(_context);
        public ITeacherRepository teacherRepository => _teacherRepository ??= new TeacherRepository(_context);
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
