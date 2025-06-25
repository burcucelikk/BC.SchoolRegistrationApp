using BC.SchoolRegistrationApp.BL.Manager;
using BC.SchoolRegistrationApp.BL.Service;
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
        public static IServiceCollection AddBLDependencies(this IServiceCollection services)
        {
            services.AddScoped<IClassService, ClassManager>();
            return services;
        }
    }
}
