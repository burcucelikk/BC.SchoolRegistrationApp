using DevExpress.Skins;
using DevExpress.UserSkins;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BC.SchoolRegistrationApp.DAL.Extensions;
using Microsoft.Extensions.DependencyInjection;
using BC.SchoolRegistrationApp.BL.Service;
using BC.SchoolRegistrationApp.BL.Manager;
using Microsoft.Extensions.Logging;
using System.Reflection;
using BC.SchoolRegistrationApp.BL.Extensions;

namespace BC.SchoolRegistrationApp.UI
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var host= CreateHostBuilder().Build();
            ServiceProvider = host.Services;
            using (var scope = ServiceProvider.CreateScope())
            {
                var services=scope.ServiceProvider;
                Application.Run(services.GetRequiredService<Home>());
            }
        }
        static IHostBuilder CreateHostBuilder()
        {
            var connectionString = "Data Source=BURCU\\SQLEXP2;Initial Catalog=SchoolRegistrationAppDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            return Host.CreateDefaultBuilder()
                .ConfigureLogging(logging =>
                {
                    logging.ClearProviders();
                    logging.AddConsole();
                })
                .ConfigureServices((context, services) => {
                    services.AddDALDependencies(connectionString);
                    services.AddBLDependencies(connectionString);
                    services.AddScoped<Home>();
                    services.AddScoped<FrmStudents>();
                });
        }
    }
}
