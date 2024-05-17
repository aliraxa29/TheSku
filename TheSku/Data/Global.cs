using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TheSku.Data;

public class Global
{
    public static string UserName { get; set; }
    public static User User { get; set; }

    public static Country Country
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                var company = dbContext.Singles.Where(c => c.Field == "default_country" && c.Doctype == "System Settings").Select(s => s.Value).FirstOrDefault();
                return dbContext.Country.Where(c => c.Name.Equals(company)).FirstOrDefault();
            }
        }
    }
    
    public static string Language
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.Singles.Where(c => c.Field == "default_language" && c.Doctype == "System Settings").Select(s => s.Value).FirstOrDefault();
            }
        }
    }
    
    public static Warehouse Warehouse
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.Warehouse.Where(c => c.Name.Equals(dbContext.Singles.Where(c => c.Field == "default_warehouse" && c.Doctype == "System Settings").Select(s => s.Value).FirstOrDefault())).FirstOrDefault();
            }
        }
    }
    
    public static Currency Currency
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.Currency.Where(c => c.Name.Equals(dbContext.Singles.Where(c => c.Field == "default_currency" && c.Doctype == "System Settings").Select(s => s.Value).FirstOrDefault())).FirstOrDefault();
            }
        }
    }

    public static Company Company
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.Company.Where(c => c.Name.Equals(dbContext.Singles.Where(c => c.Field == "default_company" && c.Doctype == "System Settings").Select(s => s.Value).FirstOrDefault())).FirstOrDefault();
            }
        }
    }

    public static decimal GetCostOfGoodsSold(object item_code)
    {
        if (item_code == null)
        {
            return 0;
        }
        return 0;
    }

    public static decimal GetPartyBalance(string partytype, string party)
    {
        using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
        {
            return dbContext.Database.SqlQueryRaw<decimal>("SELECT COALESCE(SUM(debit - credit), 0) AS balance FROM `tabGl Entry` WHERE gle.party_type = {0} AND gle.party = {1}", partytype, party).FirstOrDefault();
        }
    }

    public static string GetAccountType(object account)
    {
        using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
        {
            return dbContext.Account.Where(a => a.Name.Equals(account)).Select(a => a.AccountType).FirstOrDefault();
        }
    }

    public static decimal CalculateCostOfGoodsSold(object item_code, object company)
    {
        if (item_code != null && company != null)
        {
            //var opening = Db.Con.Query("");
        }
        return 0;
    }

    public static GLEntry MakeGLEntry(int docstatus, DateTime posting_date, DateTime transaction_date, Account account, string party_type, string party,
        CostCenter cost_center, decimal debit, decimal credit, Currency account_currency, string against, string against_voucher_type, string against_voucher, string voucher_type, string voucher_no,
        string remarks, bool is_opening, bool is_advance, FiscalYear fiscal_year, Company company, FinanceBook finance_book, bool is_cancelled)
    {
        try
        {
            return new GLEntry
            {
                Docstatus = docstatus,
                ModifiedBy = Global.UserName,
                Owner = Global.UserName,
                PostingDate = posting_date,
                TransactionDate = transaction_date,
                Account = account,
                PartyType = party_type,
                Party = party,
                CostCenter = cost_center,
                Debit = debit,
                Credit = credit,
                Currency = account_currency,
                Against = against,
                AgainstVoucherType = against_voucher_type,
                AgainstVoucher = against_voucher,
                VoucherType = voucher_type,
                VoucherNo = voucher_no,
                Remarks = remarks,
                IsOpening = is_opening,
                IsAdvance = is_advance,
                FiscalYear = fiscal_year,
                Company = company,
                FinanceBook = finance_book,
                IsCancelled = is_cancelled,
            };
        }
        catch (Exception)
        {

        }
        return new GLEntry();
    }

    public static decimal GetPartyBalance(PartyType partyType, object party)
    {
        using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
        {
            if (partyType == PartyType.Customer)
            {
                return dbContext.Database.SqlQueryRaw<decimal>("SELECT COALESCE(SUM(debit - credit), 0) AS balance FROM `tabGl Entry` WHERE gle.party_type = 'Customer' AND gle.party = {1};", party).FirstOrDefault();
            }
            else if (partyType == PartyType.Supplier)
            {
                return dbContext.Database.SqlQueryRaw<decimal>("SELECT COALESCE(SUM(debit - credit), 0) AS balance FROM `tabGl Entry` WHERE gle.party_type = 'Supplier' AND gle.party = {1};", party).FirstOrDefault();
            }
            else if (partyType == PartyType.Donor)
            {
                return dbContext.Database.SqlQueryRaw<decimal>("SELECT COALESCE(SUM(debit - credit), 0) AS balance FROM `tabGl Entry` WHERE gle.party_type = 'Donor' AND gle.party = {1};", party).FirstOrDefault();
            }
            else if (partyType == PartyType.Shareholder)
            {
                return dbContext.Database.SqlQueryRaw<decimal>("SELECT COALESCE(SUM(debit - credit), 0) AS balance FROM `tabGl Entry` WHERE gle.party_type = 'Shareholder' AND gle.party = {1};", party).FirstOrDefault();
            }
            else if (partyType == PartyType.Employee)
            {
                return dbContext.Database.SqlQueryRaw<decimal>("SELECT COALESCE(SUM(debit - credit), 0) AS balance FROM `tabGl Entry` WHERE gle.party_type = 'Employee' AND gle.party = {1};", party).FirstOrDefault();
            }
            else if (partyType == PartyType.Student)
            {
                return dbContext.Database.SqlQueryRaw<decimal>("SELECT COALESCE(SUM(debit - credit), 0) AS balance FROM `tabGl Entry` WHERE gle.party_type = 'Student' AND gle.party = {1};", party).FirstOrDefault();
            }
        }
        return 0;
    }

    public static decimal GetAccountBalance(object account)
    {
        using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
        {
            return dbContext.Database.SqlQueryRaw<decimal>("SELECT COALESCE(SUM(debit - credit), 0) AS balance FROM `tabGl Entry` WHERE gle.account = {0} AND is_cancelled = 0;", account).FirstOrDefault();
        }
    }

    public static FiscalYear GetFiscalYear(string company)
    {
        using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
        {
            return dbContext.FiscalYearCompany.Where(a => a.Company.Equals(company)).Select(a => a.FiscalYear).FirstOrDefault();
        }
    }

    public static Currency GetAccountCurreny(object account)
    {
        using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
        {
            return dbContext.Account.Where(a => a.Name.Equals(account)).Select(a => a.Currency).FirstOrDefault();
        }
    }

    public static Account GetRoundOffAccount()
    {
        using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
        {
            return /*dbContext.Company.Where(a => a.Name.Equals(Global.Company)).FirstOrDefault().RoundOffAccount*/new Account();
        }
    }

    public static Account GetDefaultPayableAccount()
    {
        using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
        {
            return /*dbContext.Company.Where(a => a.Name.Equals(Global.Company)).FirstOrDefault().DefaultPayableAccount*/ new Account();
        }
    }

    /// <summary>
    /// Get Actual aavailable Qty in the specified warehouse
    /// </summary>
    /// <param name="ItemCode">Item Code of the item that you want to get actual qty</param>
    /// <param name="warehouse">Warehouse for the item where the actual qty is available</param>
    /// <returns>Returns the total actual available qty in the warehouse</returns>
    public static decimal GetActualQty(object ItemCode, object warehouse)
    {
        using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
        {
            return dbContext.Bin.Where(c => c.ItemCode.Equals(ItemCode) && c.Warehouse.Equals(warehouse)).Sum(b => b.ActualQty);
        }
    }

    /// <summary>
    /// Gets the conversion factor for the specified uom.
    /// </summary>
    /// <param name="ItemCode">Item code that you want to get for item.</param>
    /// <param name="uom">Uom that you want to get conversion factor for.</param>
    /// <returns>Returns the decimal value of conversion factor</returns>
    public static decimal GetUomConversionFactor(object ItemCode, object uom)
    {
        using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
        {
            return dbContext.UomConversionDetail.Where(c => c.ItemCode.Equals(dbContext.Item.Where(i => i.Name.Equals(ItemCode)).FirstOrDefault()) && c.Uom.Equals(uom)).FirstOrDefault().ConversionFactor;
        }
    }

    public static decimal GetAveragePrice(object ItemCode, object warehouse)
    {
        using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
        {
            return dbContext.Bin.Where(c => c.ItemCode.Equals(ItemCode) && c.Warehouse.Equals(warehouse)).Average(b => b.ValuationRate);
        }
    }

    public static List<ItemTaxTemplateDetail> GetItemTaxTemplate(object ItemTaxTemplate)
    {
        using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
        {
            return dbContext.ItemTaxTemplate.Where(i => i.Name.Equals(ItemTaxTemplate)).Select(i => i.ItemTaxTemplateDetails).FirstOrDefault();
        }
    }

    public SalesInvoice AddSalesInvoice(int docstatus, string fbr_invoice_no, DateTime fbr_date, Customer customer,
        string tax_id, string patient_name, PosProfile pos_profile, bool is_pos, bool is_consolidated, bool is_return,
        Company company, string company_tax_id, DateTime posting_date, TimeSpan posting_time, bool set_posting_time, DateTime due_date, string return_against,
        CostCenter cost_center, string customer_address, string contact_person, string contact_mobile, string contact_email,
        Territory territory, string shipping_address, string company_address, Currency currency, decimal conversion_rate, PriceList selling_price_list, Currency price_list_currency, decimal plc_conversion_rate, bool ignore_pricing_rule,
        bool update_stock, decimal total_qty, decimal base_total, decimal base_net_total, decimal total, decimal net_total, decimal total_taxes_and_charges, decimal loyalty_points, decimal loyalty_amount,
        bool redeem_loyalty_points, LoyaltyProgram loyalty_program, Account loyalty_redemption_account, CostCenter loyalty_redemption_cost_center,
        decimal additional_discount_percentage, decimal discount_amount, decimal base_grand_total, decimal base_rounding_adjustment, decimal base_rounded_total,
        string base_in_words, decimal grand_total, decimal rounding_adjustment, decimal rounded_total, string in_words, decimal total_advance, decimal outstanding_amount, bool disable_rounded_total,
        decimal base_paid_amount, decimal paid_amount, decimal base_change_amount, decimal change_amount, string account_for_change_amount, string status, Account debit_to, Currency party_account_currency, string remarks, Account against_income_account,
        int is_settled, int print_count, int items_count)
    {
        return new SalesInvoice
        {
            ModifiedBy = Global.UserName,
            Owner = Global.UserName,
            Creation = Utility.Now,
            Docstatus = docstatus,
            FiscalInvoiceNo = fbr_invoice_no,
            FiscalInvoiceDate = fbr_date,
            Customer = customer,
            TaxId = tax_id,
            PatientName = patient_name,
            PosProfile = pos_profile,
            IsPos = is_pos,
            IsConsolidated = is_consolidated,
            IsReturn = is_return,
            Company = company,
            CompanyTaxId = company_tax_id,
            PostingDate = posting_date,
            PostingTime = posting_time,
            SetPostingTime = set_posting_time,
            DueDate = due_date,
            ReturnAgainst = return_against,
            CostCenter = cost_center,
            CustomerAddress = customer_address,
            ContactPerson = contact_person,
            ContactMobile = contact_mobile,
            ContactEmail = contact_email,
            Territory = territory,
            ShippingAddress = shipping_address,
            CompanyAddress = company_address,
            Currency = currency,
            ConversionRate = conversion_rate,
            PriceList = selling_price_list,
            PriceListCurrency = price_list_currency,
            PlcConversionRate = plc_conversion_rate,
            IgnorePricingRule = ignore_pricing_rule,
            UpdateStock = update_stock,
            TotalQty = total_qty,
            BaseTotal = base_total,
            BaseNetTotal = base_net_total,
            Total = total,
            NetTotal = net_total,
            TotalTaxesCharges = total_taxes_and_charges,
            LoyaltyPoints = loyalty_points,
            LoyaltyAmount = loyalty_amount,
            RedeemLoyaltyPoints = redeem_loyalty_points,
            LoyaltyProgram = loyalty_program,
            LoyaltyRedemptionAccount = loyalty_redemption_account,
            LoyaltyRedemptionCostCenter = loyalty_redemption_cost_center,
            AdditionalDiscountPercentage = additional_discount_percentage,
            DiscountAmount = discount_amount,
            BaseGrandTotal = base_grand_total,
            BaseRoundingAdjustment = base_rounding_adjustment,
            BaseRoundedTotal = base_rounded_total,
            BaseInWords = base_in_words,
            GrandTotal = grand_total,
            RoundingAdjustment = rounding_adjustment,
            RoundedTotal = rounded_total,
            InWords = in_words,
            TotalAdvance = total_advance,
            OutstandingAmount = outstanding_amount,
            DisableRoundedTotal = disable_rounded_total,
            BasePaidAmount = base_paid_amount,
            PaidAmount = paid_amount,
            BaseChangeAmount = base_change_amount,
            ChangeAmount = change_amount,
            AccountForChangeAmount = account_for_change_amount,
            Status = status,
            DebitTo = debit_to,
            PartyAccountCurrency = party_account_currency,
            Remarks = remarks,
            AgainstIncomeAccount = against_income_account,
            IsSettled = is_settled,
            PrintCount = print_count,
            TotalItems = items_count,
        };
    }

    public SalesInvoiceItem AddSalesInvoiceItem(int docstatus, SalesInvoice parent, string barcode, Item item_code, string item_name, string description,
        ItemGroup item_group, Brand brand, PackingType packing_type, string packing, decimal qty, Uom stock_uom, Uom uom, decimal conversion_factor, decimal stock_qty, decimal price_list_rate, decimal base_price_list_rate,
        decimal total, decimal discount_percentage, decimal discount_amount, decimal rate, decimal amount, ItemTaxTemplate item_tax_template, decimal tax_amount, decimal base_rate, decimal base_amount, decimal stock_uom_rate,
        decimal net_rate, decimal net_amount, decimal base_net_rate, decimal base_net_amount, Account income_account,
        FinanceBook finance_book, Account expense_account, Warehouse warehouse, string batch_no, decimal incoming_rate, CostCenter cost_center, bool is_settled, string doctor_name, DateTime expiry_date, string rack_location)
    {
        return new SalesInvoiceItem
        {
            ModifiedBy = Global.UserName,
            Owner = Global.UserName,
            Docstatus = docstatus,
            SalesInvoice = parent,
            Barcode = barcode,
            ItemCode = item_code,
            ItemName = item_name,
            Description = description,
            ItemGroup = item_group,
            Brand = brand,
            PackingType = packing_type,
            Packing = packing,
            Qty = qty,
            StockUom = stock_uom,
            Uom = uom,
            ConversionFactor = conversion_factor,
            StockQty = stock_qty,
            PriceListRate = price_list_rate,
            BasePriceListRate = base_price_list_rate,
            Total = total,
            DiscountPercentage = discount_percentage,
            DiscountAmount = discount_amount,
            Rate = rate,
            Amount = amount,
            ItemTaxTemplate = item_tax_template,
            TaxAmount = tax_amount,
            BaseRate = base_rate,
            BaseAmount = base_amount,
            StockUomRate = stock_uom_rate,
            NetRate = net_rate,
            NetAmount = net_amount,
            BaseNetRate = base_net_rate,
            BaseNetAmount = base_net_amount,
            IncomeAccount = income_account,
            FinanceBook = finance_book,
            ExpenseAccount = expense_account,
            Warehouse = warehouse,
            BatchNo = batch_no,
            IncomingRate = incoming_rate,
            CostCenter = cost_center,
            IsSettled = is_settled,
            DoctorName = doctor_name,
            ExpiryDate = expiry_date,
            RackLocation = rack_location,
        };
    }

    public static Account GetWarehouseStockAccount(Warehouse warehouse)
    {
        using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
        {
            return dbContext.Warehouse.Where(w => w.Equals(warehouse)).FirstOrDefault().Account;
        }
    }
}