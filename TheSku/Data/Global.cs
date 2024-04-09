using System.Linq;
using TheSku.Data;

public class Global
{
    public static string UserName { get; set; }

    public static string Country
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                var default_country = dbContext.Singles.Where(c => c.Field == "default_country" && c.Doctype == "Session").FirstOrDefault();
                return default_country?.Value;
            }
        }
    }
    
    public static string Currency
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                var default_currency = dbContext.Singles.Where(c => c.Field == "default_currency" && c.Doctype == "Session").FirstOrDefault();
                return default_currency?.Value;
            }
        }
    }
    public static string Company
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                var cd = dbContext.Singles.Where(c => c.Field == "default_company").FirstOrDefault();
                return cd?.Value;
            }
        }
    }
}