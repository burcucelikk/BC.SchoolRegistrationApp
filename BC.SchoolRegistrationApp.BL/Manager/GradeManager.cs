using AutoMapper;
using BC.SchoolRegistrationApp.BL.Service;
using BC.SchoolRegistrationApp.DAL.Abstract;
using BC.SchoolRegistrationApp.DAL.Concrete;
using BC.SchoolRegistrationApp.Dto.Concrete.Grade;
using BC.SchoolRegistrationApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.BL.Manager
{
    public class GradeManager : GenericManagerDto<Grade, GradeDto, GradeAddDto, GradeUpdateDto, GradeListDto, GradeDetailDto>, IGradeService
    {
        private readonly IGradeRepository _gradeRepository;
        public GradeManager(IUow uow, IMapper mapper) : base(uow, mapper)
        {
            _gradeRepository =uow.gradeRepository;
        }
        public List<GradeDetailDto> GetGradesByStudentId(int studentId)
        {
            var grades = _gradeRepository.GetQueryable()
                .Include(x=>x.Exam)
                .Include(x=>x.Lesson)
                .Where(x => x.StudentID == studentId)
                .ToList();
            var gradeDtos = _mapper.Map<List<GradeDetailDto>>(grades);
            return gradeDtos;
        }
    }
}
