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
    public class LessonConfiguration :IEntityTypeConfiguration<Lesson>
    {
        public void Configure (EntityTypeBuilder<Lesson> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Name)
                .IsRequired();
            builder.Property(x => x.WeeklyHour)
                .IsRequired();
        }

    }
}
