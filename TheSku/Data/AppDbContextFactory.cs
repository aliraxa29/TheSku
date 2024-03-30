using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Configuration;
using TheSku.Data;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseMySql(ConfigurationManager.ConnectionStrings["ConString"].ToString(), ServerVersion.AutoDetect(ConfigurationManager.ConnectionStrings["ConString"].ToString()));

        return new AppDbContext(optionsBuilder.Options);
    }
}
