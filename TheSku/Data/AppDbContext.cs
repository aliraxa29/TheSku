using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;
using System.Linq;
using TheSku.Data;

namespace TheSku.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConfigurationManager.ConnectionStrings["ConString"].ToString(), ServerVersion.AutoDetect(ConfigurationManager.ConnectionStrings["ConString"].ToString()));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var fk in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            }
            modelBuilder.Entity<Company>().HasOne(c => c.RoundOffAccount).WithOne().HasForeignKey<Company>(c => c.RoundOffAccountId).IsRequired(false);
            modelBuilder.Entity<Item>().HasIndex(i => new { i.ItemName, i.Modified }).HasDatabaseName("idx_item_itemname_modified");
            modelBuilder.Entity<Role>().HasData(DefaultData.Roles());
            modelBuilder.Entity<PackingType>().HasData(DefaultData.PackingTypes());
            modelBuilder.Entity<Country>().HasData(DefaultData.Countries());
            modelBuilder.Entity<Currency>().HasData(DefaultData.Currencies());
            modelBuilder.Entity<Language>().HasData(DefaultData.Languages());
            modelBuilder.Entity<Document>().HasData(DefaultData.Documents());
            var defaultSingles = DefaultData.DefaultValues().Select(s => new Singles
            {
                Name = Guid.NewGuid(),
                Creation = s.Creation,
                Modified = s.Modified,
                ModifiedBy = s.ModifiedBy,
                Owner = s.Owner,
                Doctype = s.Doctype,
                Label = s.Label,
                Field = s.Field,
                Value = s.Value
            }).ToList();
            modelBuilder.Entity<Singles>().HasData(defaultSingles);
        }

        public DbSet<Brand> Brand { get; set; }
        public DbSet<Bin> Bin { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<ItemGroup> ItemGroup { get; set; }
        public DbSet<ItemPrice> ItemPrice { get; set; }
        public DbSet<ItemTaxTemplate> ItemTaxTemplate { get; set; }
        public DbSet<LoyaltyProgram> LoyaltyProgram { get; set; }
        public DbSet<PackingType> PackingType { get; set; }
        public DbSet<PosProfile> PosProfile { get; set; }
        public DbSet<PriceList> PriceList { get; set; }
        public DbSet<SalesInvoice> SalesInvoice { get; set; }
        public DbSet<Territory> Territory { get; set; }
        public DbSet<Uom> Uom { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SupplierGroup> SupplierGroup { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomerGroup> CustomerGroup { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Singles> Singles { get; set; }
        public DbSet<CostCenter> CostCenter { get; set; }
        public DbSet<FinanceBook> FinanceBook { get; set; }
        public DbSet<FiscalYear> FiscalYear { get; set; }
        public DbSet<GLEntry> GLEntries { get; set; }
        public DbSet<UomConversionDetail> UomConversionDetail { get; set; }
        public DbSet<Warehouse> Warehouse { get; set; }
        public DbSet<FiscalYearCompany> FiscalYearCompany { get; set; }
        public DbSet<SalesInvoicePayment> SalesInvoicePayment { get; set; }
        public DbSet<ModeOfPayment> ModeOfPayment { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserPermission> UserPermissions { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<StockLedger> StockLedger { get; set; }
    }
}

public static class DbContextOptionsProvider
{
    public static DbContextOptions<AppDbContext> Options { get; }

    static DbContextOptionsProvider()
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseMySql(ConfigurationManager.ConnectionStrings["ConString"].ToString(), ServerVersion.AutoDetect(ConfigurationManager.ConnectionStrings["ConString"].ToString()));
        Options = optionsBuilder.Options;
    }
}
