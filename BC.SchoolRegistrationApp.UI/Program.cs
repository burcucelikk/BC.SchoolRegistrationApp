using DevExpress.Skins;
using DevExpress.UserSkins;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BC.SchoolRegistrationApp.DAL.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace BC.SchoolRegistrationApp.UI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var host = Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                var connectionString = "Data Source=BURCU\\SQLEXP2;Initial Catalog=SchoolRegistrationAppDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
                services.AddDALDependencies(connectionString);
                services.AddScoped<Home>();
            })
                .Build();
            using (var scope = host.Services.CreateScope())
            {
                var services=scope.ServiceProvider;
                Application.Run(services.GetRequiredService<Home>());
            }
        }
    }
}
