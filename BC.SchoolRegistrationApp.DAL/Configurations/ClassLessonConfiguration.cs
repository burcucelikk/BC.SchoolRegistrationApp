using BC.SchoolRegistrationApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.DAL.Configurations
{
    public class ClassLessonConfiguration : IEntityTypeConfiguration<ClassLesson>
    {
        public void Configure(EntityTypeBuilder<ClassLesson> builder)
        {
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Class)
                .WithMany(x => x.ClassLessons)
                .HasForeignKey(x => x.ClassID);
            builder.HasOne(x => x.Lesson)
                .WithMany(x => x.ClassLessons)
                .HasForeignKey(x => x.LessonID);
            builder.HasOne(x => x.Teacher)
                .WithMany(x => x.ClassLessons)
                .HasForeignKey(x => x.TeacherID);
        }
    }
}
