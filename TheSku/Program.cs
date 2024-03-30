using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using TheSku.Data;

namespace TheSku
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // Use the service provider to create the main form
            Application.Run(serviceProvider.GetRequiredService<frmLogin>());
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmLogin());
        }
        private static void ConfigureServices(IServiceCollection services)
        {
            // Configure the DbContext with the connection string
            services.AddDbContext<AppDbContext>(options =>
                options.UseMySql(ConfigurationManager.ConnectionStrings["ConString"].ToString(), ServerVersion.AutoDetect(ConfigurationManager.ConnectionStrings["ConString"].ToString())));
            services.AddTransient<frmLogin>();
        }
    }
}