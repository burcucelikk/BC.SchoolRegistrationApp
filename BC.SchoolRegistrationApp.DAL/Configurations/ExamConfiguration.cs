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
    public class ExamConfiguration : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x=>x.ID)
                .ValueGeneratedOnAdd();

            builder.HasOne(x => x.Lesson)
                .WithMany(x => x.Exams)
                .HasForeignKey(x => x.LessonID);

        }
    }
}
