using BC.SchoolRegistrationApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.DAL.Seeds
{
    public class GradeSeedData : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            var grades= new List<Grade>();
            int gradeId = 1;
            int examId = 1;
            int totalStudents=60;
            var rnd = new Random();

            for (int lessonId=1; lessonId<=13; lessonId++)
            {
                for(int examTypeId=1; examTypeId <= 3; examTypeId++)
                {
                    for(int studentId=1; studentId <= 60; studentId++)
                    {

                        double score = rnd.Next(0, 101);
                        grades.Add(new Grade
                        {
                            ID = gradeId++,
                            StudentID = studentId,
                            ExamID = examId,
                            LessonID = lessonId,
                            Score = score
                        });
                    }
                    examId++;
                }
            }
            builder.HasData(grades);
        }
    }
}
