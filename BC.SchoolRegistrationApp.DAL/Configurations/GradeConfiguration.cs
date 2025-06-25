using BC.SchoolRegistrationApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace BC.SchoolRegistrationApp.DAL.Configurations
{
    public class GradeConfiguration : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder.HasKey(x=>x.ID);

            builder.Property(x => x.ID)
                .ValueGeneratedOnAdd();

            builder.HasOne(x => x.Student)
                .WithMany(x => x.Grades)
                .HasForeignKey(x => x.StudentID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Lesson)
                .WithMany(x => x.Grades)
                .HasForeignKey(x => x.LessonID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Exam)
                .WithMany(x => x.Grades)
                .HasForeignKey(x => x.ExamID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
