using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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
            AppDbContext dbContext = new AppDbContext(DbContextOptionsProvider.Options);
            if (dbContext.Company.Count() <= 0)
            {
                new frmCompanySetup(dbContext).ShowDialog();
            }
            else
            {
                Application.Run(serviceProvider.GetRequiredService<frmLogin>());
            }
        }
        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseMySql(ConfigurationManager.ConnectionStrings["ConString"].ToString(), ServerVersion.AutoDetect(ConfigurationManager.ConnectionStrings["ConString"].ToString())));
            services.AddTransient<frmLogin>();
        }
    }
}