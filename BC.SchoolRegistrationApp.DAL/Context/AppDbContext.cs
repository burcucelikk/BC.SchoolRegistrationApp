using BC.SchoolRegistrationApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.DAL.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<LessonHour> LessonHour { get; set; }
        public DbSet<LessonSchedule> LessonSchedule { get; set; }
        
        public AppDbContext(DbContextOptions<AppDbContext> option): base(option)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);

            //Teacher
            modelBuilder.Entity<Teacher>(entity =>
            {

            });

            //Student
            modelBuilder.Entity<Student>(entity =>
            {

            });

            //Class 
            modelBuilder.Entity<Class>(entity =>
            {

            });

            //Lesson 
            modelBuilder.Entity<Lesson>(entity =>
            {

            });

            //LessonHour 
            modelBuilder.Entity<Lesson>(entity =>
            {

            });

            //LessonSchedule 
            modelBuilder.Entity<Lesson>(entity =>
            {

            });
        }
    }
}
