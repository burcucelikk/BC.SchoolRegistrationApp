using BC.SchoolRegistrationApp.Entity.Entities;
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
    public class LessonSeedData : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            var lessons = new[]
            {
                new Lesson { ID = 1, Name = "English", WeeklyHour = 4 },
                new Lesson { ID = 2, Name = "Turkish", WeeklyHour = 5 },
                new Lesson { ID = 3, Name = "Mathematics", WeeklyHour = 6 },
                new Lesson { ID = 4, Name = "Physics", WeeklyHour = 4 },
                new Lesson { ID = 5, Name = "Chemistry", WeeklyHour = 2 },
                new Lesson { ID = 6, Name = "Biology", WeeklyHour = 2 },
                new Lesson { ID = 7, Name = "History", WeeklyHour = 2 },
                new Lesson { ID = 8, Name = "Geography", WeeklyHour = 2 },
                new Lesson { ID = 9, Name = "Religious Culture and Moral Knowledge", WeeklyHour = 1 },
                new Lesson { ID = 10, Name = "Physical Education and Sports", WeeklyHour = 2 },
                new Lesson { ID = 11, Name = "Visual Arts / Music", WeeklyHour = 2 },
                new Lesson { ID = 12, Name = "Health Knowledge and Traffic Culture", WeeklyHour = 1 },
                new Lesson { ID = 13, Name = "German", WeeklyHour = 3 }
            };
            builder.HasData(lessons);
        }
    }
}
