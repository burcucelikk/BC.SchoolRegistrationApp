using BC.SchoolRegistrationApp.BL.Manager;
using BC.SchoolRegistrationApp.BL.Service;
using BC.SchoolRegistrationApp.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.BL.Extensions
{
    public static class BLDependencies
    {
        public static IServiceCollection AddBLDependencies(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<AppDbContext>(x =>
            {
                x.UseSqlServer(connectionString);
            });
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<IClassService, ClassManager>();
            services.AddScoped<IStudentService, StudentManager>();
            services.AddScoped<ILessonService, LessonManager>();
            services.AddScoped<ITeacherService, TeacherManager>();
            return services;
        }
    }
}
