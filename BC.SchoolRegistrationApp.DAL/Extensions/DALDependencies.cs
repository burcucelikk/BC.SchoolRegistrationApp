using BC.SchoolRegistrationApp.DAL.Abstract;
using BC.SchoolRegistrationApp.DAL.Concrete;
using BC.SchoolRegistrationApp.DAL.Context;
using BC.SchoolRegistrationApp.DAL.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.DAL.Extensions
{
    public static class DALDependencies
    {
        public static IServiceCollection AddDALDependencies (this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<AppDbContext>(x =>
            {
                x.UseSqlServer(connectionString);
            });

            services.AddScoped<IClassRepository, ClassRepository>();
            services.AddScoped<IClassLessonRepository, ClassLessonRepository>();
            services.AddScoped<IGradeRepository, GradeRepository>();
            services.AddScoped<ILessonRepository, LessonRepository>();
            services.AddScoped<ILessonScheduleRepository, LessonScheduleRepository>();
            services.AddScoped<IExamRepository, ExamRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            services.AddScoped<IUow, Uow>();

            return services;
        }
    }
}
