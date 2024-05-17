using System.Linq;
using TheSku.Data;

public class PosProfileSetting
{

    public static Warehouse Warehouse
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.Warehouse.Where(c => c.Name.Equals(Global.Warehouse) && c.Enabled && c.Company.Equals(Global.Company)).FirstOrDefault();
            }
        }
    }

    public static PosProfile PosProfile
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                var d = dbContext.PosProfile.Where(c => c.Warehouse.Equals(Global.Warehouse) && !c.Disabled && c.Company.Equals(Global.Company)).FirstOrDefault();
                return d;
            }
        }
    }
    public static Company Company
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Warehouse.Equals(Global.Warehouse) && !c.Disabled && c.Company.Equals(Global.Company)).FirstOrDefault().Company;
            }
        }
    }
    public static string Customer
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Warehouse.Equals(Global.Warehouse) && !c.Disabled && c.Company.Equals(Global.Company)).FirstOrDefault().Customer.Name;
            }
        }
    }
    public static string Country
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Warehouse.Equals(Global.Warehouse) && !c.Disabled && c.Company.Equals(Global.Company)).FirstOrDefault().Country.Name;
            }
        }
    }
    public static string CompanyAddress
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Warehouse.Equals(Global.Warehouse) && !c.Disabled && c.Company.Equals(Global.Company)).FirstOrDefault().CompanyAddress;
            }
        }
    }
    public static bool ValidateStock
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Warehouse.Equals(Global.Warehouse) && !c.Disabled && c.Company.Equals(Global.Company)).FirstOrDefault().ValidateStockOnSave;
            }
        }
    }
    public static bool UpdateStock
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Warehouse.Equals(Global.Warehouse) && !c.Disabled && c.Company.Equals(Global.Company)).FirstOrDefault().UpdateStock;
            }
        }
    }
    public static bool IgnorePricingRule
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Warehouse.Equals(Global.Warehouse) && !c.Disabled && c.Company.Equals(Global.Company)).FirstOrDefault().IgnorePricingRule;
            }
        }
    }
    public static bool AllowChangeRate
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Warehouse.Equals(Global.Warehouse) && !c.Disabled && c.Company.Equals(Global.Company)).FirstOrDefault().AllowChangeRate;
            }
        }
    }
    public static bool AllowChangeDiscount
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Warehouse.Equals(Global.Warehouse) && !c.Disabled && c.Company.Equals(Global.Company)).FirstOrDefault().AllowChangeDiscount;
            }
        }
    }
    public static string PrintFormat
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Warehouse.Equals(Global.Warehouse) && !c.Disabled && c.Company.Equals(Global.Company)).FirstOrDefault().PrintFormat;
            }
        }
    }
    public static string PriceList
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Warehouse.Equals(Global.Warehouse) && !c.Disabled && c.Company.Equals(Global.Company)).FirstOrDefault().PriceList.Name;
            }
        }
    }
    public static string Currency
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Warehouse.Equals(Global.Warehouse) && !c.Disabled && c.Company.Equals(Global.Company)).FirstOrDefault().Currency.Name;
            }
        }
    }
    public static string WriteOffAccount
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Warehouse.Equals(Global.Warehouse) && !c.Disabled && c.Company.Equals(Global.Company)).FirstOrDefault().WriteOffAccount.Name;
            }
        }
    }
    public static string WriteOffCostCenter
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Warehouse.Equals(Global.Warehouse) && !c.Disabled && c.Company.Equals(Global.Company)).FirstOrDefault().WriteOffCostCenter.Name;
            }
        }
    }
    public static decimal WriteOffLimit
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Warehouse.Equals(Global.Warehouse) && !c.Disabled && c.Company.Equals(Global.Company)).FirstOrDefault().WriteOffLimit;
            }
        }
    }
    public static string AccountForChangeAmount
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Warehouse.Equals(Global.Warehouse) && !c.Disabled && c.Company.Equals(Global.Company)).FirstOrDefault().AccountForChangeAmount.Name;
            }
        }
    }
    public static bool DisableRoundedTotal
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Warehouse.Equals(Global.Warehouse) && !c.Disabled && c.Company.Equals(Global.Company)).FirstOrDefault().DisableRoundedTotal;
            }
        }
    }
    public static string IncomeAccount
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Warehouse.Equals(Global.Warehouse) && !c.Disabled && c.Company.Equals(Global.Company)).FirstOrDefault().IncomeAccount.Name;
            }
        }
    }
    public static string ExpenseAccount
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Warehouse.Equals(Global.Warehouse) && !c.Disabled && c.Company.Equals(Global.Company)).FirstOrDefault().ExpenseAccount.Name;
            }
        }
    }
    public static string CostCenter
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Warehouse.Equals(Global.Warehouse) && !c.Disabled && c.Company.Equals(Global.Company)).FirstOrDefault().CostCenter.Name;
            }
        }
    }

    public static decimal AdditionalDiscountLimit
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Warehouse.Equals(Global.Warehouse) && !c.Disabled && c.Company.Equals(Global.Company)).FirstOrDefault().AdditionalDiscountLimit;
            }
        }
    }
}