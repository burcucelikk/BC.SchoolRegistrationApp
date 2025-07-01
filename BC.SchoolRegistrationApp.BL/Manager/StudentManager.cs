using AutoMapper;
using BC.SchoolRegistrationApp.BL.Service;
using BC.SchoolRegistrationApp.DAL.Abstract;
using BC.SchoolRegistrationApp.Dto.Concrete;
using BC.SchoolRegistrationApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BC.SchoolRegistrationApp.BL.Manager
{
    public class StudentManager : GenericManager<Student,StudentDto>, IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentManager(IUow uow, IMapper mapper) : base(uow, mapper)
        {
            _studentRepository = uow.studentRepository;
        }
        public List<StudentDto> GetStudentsWithClassName(string className)
        {
            return _studentRepository.GetQueryable().Include(x=>x.Class).Where(x=>x.Class.Name==className).Select(x=> new StudentDto
            {
                Id= x.ID,
                Name= x.Name,
                Surname= x.Surname,
                ClassName= x.Class.Name,
                Photograph= x.Photograph,
                Number= x.Number,
                IsPassed= x.IsPassed
            }).ToList();
        }
    }
}
