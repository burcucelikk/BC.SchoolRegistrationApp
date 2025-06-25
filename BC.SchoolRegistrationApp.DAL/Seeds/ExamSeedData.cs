using BC.SchoolRegistrationApp.Entity.Entities;
using BC.SchoolRegistrationApp.Entity.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.DAL.Seeds
{
    public class ExamSeedData : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            var exams = new List<Exam>();
            int examId = 1;
            for (int lessonId = 1; lessonId <= 13; lessonId++)
            {
                exams.Add(new Exam { ID = examId++, LessonID = lessonId, ExamType = ExamType.First });
                exams.Add(new Exam { ID = examId++, LessonID = lessonId, ExamType = ExamType.Second });
                exams.Add(new Exam { ID = examId++, LessonID = lessonId, ExamType = ExamType.Third });
            }
            builder.HasData(exams);
        }
    }
}
