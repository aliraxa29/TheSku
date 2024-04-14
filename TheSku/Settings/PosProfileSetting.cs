using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TheSku.Data;

public class PosProfileSetting
{
    private Dictionary<string, object> Filters = new Dictionary<string, object>()
    {
        {"warehouse", Global.Warehouse },
        {"disabled", 0 },
        {"company", Global.Company },
    };

    public static Warehouse Warehouse
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.Warehouse.Where(c => c.Name.Equals(Global.Warehouse) && !c.Disabled && c.Company == dbContext.Company.Where(c => c.Name.Equals(Global.Company)).FirstOrDefault()).FirstOrDefault();
            }
        }
    }

    public static PosProfile PosProfile
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Name.Equals(Global.Warehouse) && !c.Disabled && c.Company == dbContext.Company.Where(c => c.Name.Equals(Global.Company)).FirstOrDefault()).FirstOrDefault();
            }
        }
    }
    public static Company Company
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Name.Equals(Global.Warehouse) && !c.Disabled && c.Company == dbContext.Company.Where(c => c.Name.Equals(Global.Company)).FirstOrDefault()).FirstOrDefault().Company;
            }
        }
    }
    public static string Customer
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Name.Equals(Global.Warehouse) && !c.Disabled && c.Company == dbContext.Company.Where(c => c.Name.Equals(Global.Company)).FirstOrDefault()).FirstOrDefault().Customer.Name;
            }
        }
    }
    public static string Country
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Name.Equals(Global.Warehouse) && !c.Disabled && c.Company == dbContext.Company.Where(c => c.Name.Equals(Global.Company)).FirstOrDefault()).FirstOrDefault().Country.Name;
            }
        }
    }
    public static string CompanyAddress
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Name.Equals(Global.Warehouse) && !c.Disabled && c.Company == dbContext.Company.Where(c => c.Name.Equals(Global.Company)).FirstOrDefault()).FirstOrDefault().CompanyAddress;
            }
        }
    }
    public static bool ValidateStock
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Name.Equals(Global.Warehouse) && !c.Disabled && c.Company == dbContext.Company.Where(c => c.Name.Equals(Global.Company)).FirstOrDefault()).FirstOrDefault().ValidateStockOnSave;
            }
        }
    }
    public static bool UpdateStock
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Name.Equals(Global.Warehouse) && !c.Disabled && c.Company == dbContext.Company.Where(c => c.Name.Equals(Global.Company)).FirstOrDefault()).FirstOrDefault().UpdateStock;
            }
        }
    }
    public static bool IgnorePricingRule
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Name.Equals(Global.Warehouse) && !c.Disabled && c.Company == dbContext.Company.Where(c => c.Name.Equals(Global.Company)).FirstOrDefault()).FirstOrDefault().IgnorePricingRule;
            }
        }
    }
    public static bool AllowChangeRate
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Name.Equals(Global.Warehouse) && !c.Disabled && c.Company == dbContext.Company.Where(c => c.Name.Equals(Global.Company)).FirstOrDefault()).FirstOrDefault().AllowChangeRate;
            }
        }
    }
    public static bool AllowChangeDiscount
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Name.Equals(Global.Warehouse) && !c.Disabled && c.Company == dbContext.Company.Where(c => c.Name.Equals(Global.Company)).FirstOrDefault()).FirstOrDefault().AllowChangeDiscount;
            }
        }
    }
    public static string PrintFormat
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Name.Equals(Global.Warehouse) && !c.Disabled && c.Company == dbContext.Company.Where(c => c.Name.Equals(Global.Company)).FirstOrDefault()).FirstOrDefault().PrintFormat;
            }
        }
    }
    public static string PriceList
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Name.Equals(Global.Warehouse) && !c.Disabled && c.Company == dbContext.Company.Where(c => c.Name.Equals(Global.Company)).FirstOrDefault()).FirstOrDefault().PriceList.Name;
            }
        }
    }
    public static string Currency
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Name.Equals(Global.Warehouse) && !c.Disabled && c.Company == dbContext.Company.Where(c => c.Name.Equals(Global.Company)).FirstOrDefault()).FirstOrDefault().Currency.Name;
            }
        }
    }
    public static string WriteOffAccount
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Name.Equals(Global.Warehouse) && !c.Disabled && c.Company == dbContext.Company.Where(c => c.Name.Equals(Global.Company)).FirstOrDefault()).FirstOrDefault().WriteOffAccount.Name;
            }
        }
    }
    public static string WriteOffCostCenter
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Name.Equals(Global.Warehouse) && !c.Disabled && c.Company == dbContext.Company.Where(c => c.Name.Equals(Global.Company)).FirstOrDefault()).FirstOrDefault().WriteOffCostCenter.Name;
            }
        }
    }
    public static decimal WriteOffLimit
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Name.Equals(Global.Warehouse) && !c.Disabled && c.Company == dbContext.Company.Where(c => c.Name.Equals(Global.Company)).FirstOrDefault()).FirstOrDefault().WriteOffLimit;
            }
        }
    }
    public static string AccountForChangeAmount
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Name.Equals(Global.Warehouse) && !c.Disabled && c.Company == dbContext.Company.Where(c => c.Name.Equals(Global.Company)).FirstOrDefault()).FirstOrDefault().AccountForChangeAmount.Name;
            }
        }
    }
    public static bool DisableRoundedTotal
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Name.Equals(Global.Warehouse) && !c.Disabled && c.Company == dbContext.Company.Where(c => c.Name.Equals(Global.Company)).FirstOrDefault()).FirstOrDefault().DisableRoundedTotal;
            }
        }
    }
    public static string IncomeAccount
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Name.Equals(Global.Warehouse) && !c.Disabled && c.Company == dbContext.Company.Where(c => c.Name.Equals(Global.Company)).FirstOrDefault()).FirstOrDefault().IncomeAccount.Name;
            }
        }
    }
    public static string ExpenseAccount
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Name.Equals(Global.Warehouse) && !c.Disabled && c.Company == dbContext.Company.Where(c => c.Name.Equals(Global.Company)).FirstOrDefault()).FirstOrDefault().ExpenseAccount.Name;
            }
        }
    }
    public static string CostCenter
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Name.Equals(Global.Warehouse) && !c.Disabled && c.Company == dbContext.Company.Where(c => c.Name.Equals(Global.Company)).FirstOrDefault()).FirstOrDefault().CostCenter.Name;
            }
        }
    }

    public static decimal AdditionalDiscountLimit
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.PosProfile.Where(c => c.Name.Equals(Global.Warehouse) && !c.Disabled && c.Company == dbContext.Company.Where(c => c.Name.Equals(Global.Company)).FirstOrDefault()).FirstOrDefault().AdditionalDiscountLimit;
            }
        }
    }
}