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
    public class ClassLessonSeedData : IEntityTypeConfiguration<ClassLesson>
    {
        public void Configure(EntityTypeBuilder<ClassLesson> builder)
        {
            //var classLessons = new List<ClassLesson>();
            //int classLessonsId = 1;
            //for (int classId = 1; classId <= 12; classId++)
            //{
            //    for (int lessonId = 1; lessonId <= 13; lessonId++)
            //    {
            //        classLessons.Add(new ClassLesson { ID = classId++, LessonID = lessonId, TeacherID = 1 });
            //    }
            //}
        }
    }
}
