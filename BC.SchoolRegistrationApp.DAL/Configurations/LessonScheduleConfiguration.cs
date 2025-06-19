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
    public class LessonScheduleConfiguration : IEntityTypeConfiguration<LessonSchedule>
    {
        public void Configure(EntityTypeBuilder<LessonSchedule> builder)
        {
            builder.HasKey(x => x.ID);

            builder.Property(x => x.Day)
                .IsRequired();

            builder.Property(x=>x.LessonHour)
                .IsRequired();

            builder.HasOne(x => x.ClassLesson)
                .WithMany(x => x.LessonSchedules)
                .HasForeignKey(x => x.ClassLessonID);
        }
    }
}
