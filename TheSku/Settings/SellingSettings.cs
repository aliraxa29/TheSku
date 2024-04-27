using System;
using System.Linq;
using TheSku.Data;

public class SellingSettings
{
    readonly string Doctype = "Selling Settings";
    AppDbContext dbContext = new AppDbContext(DbContextOptionsProvider.Options);

    public string CustomerNamingBy
    {
        get
        {
            return dbContext.Singles.Where(s => s.Field.Equals("customer_naming_by") && s.Doctype.Equals(Doctype)).Select(s => s.Value).FirstOrDefault();
        }
    }

    public decimal MinimumMarginPercentage
    {
        get
        {
            return Convert.ToDecimal(dbContext.Singles.Where(s => s.Field.Equals("customer_naming_by") && s.Doctype.Equals(Doctype)).Select(s => s.Value).FirstOrDefault());
        }
    }

    public string DefaultCustomerGroup
    {
        get
        {
            return dbContext.Singles.Where(s => s.Field.Equals("default_customer_group") && s.Doctype.Equals(Doctype)).Select(s => s.Value).FirstOrDefault();
        }
    }

    public string DefaultCustomerInPOS
    {
        get
        {
            return dbContext.Singles.Where(s => s.Field.Equals("default_customer_in_pos") && s.Doctype.Equals(Doctype)).Select(s => s.Value).FirstOrDefault();
        }
    }

    public string DefaultTerritory
    {
        get
        {
            return dbContext.Singles.Where(s => s.Field.Equals("default_territory") && s.Doctype.Equals(Doctype)).Select(s => s.Value).FirstOrDefault();
        }
    }

    public string DefaultSaleUOM
    {
        get
        {
            return dbContext.Singles.Where(s => s.Field.Equals("default_sale_uom") && s.Doctype.Equals(Doctype)).Select(s => s.Value).FirstOrDefault();
        }
    }

    public string DefaultBuyingUOM
    {
        get
        {
            return dbContext.Singles.Where(s => s.Field.Equals("default_buying_uom") && s.Doctype.Equals(Doctype)).Select(s => s.Value).FirstOrDefault();
        }
    }

    public string DefaultSellingPriceList
    {
        get
        {
            return dbContext.Singles.Where(s => s.Field.Equals("default_selling_price_list") && s.Doctype.Equals(Doctype)).Select(s => s.Value).FirstOrDefault();
        }
    }

    public bool AllowEditRateInSalesTransactions
    {
        get
        {
            return Convert.ToBoolean(Convert.ToInt16(dbContext.Singles.Where(s => s.Field.Equals("allow_edit_rate_in_sales_transactions") && s.Doctype.Equals(Doctype)).Select(s => s.Value).FirstOrDefault()));
        }
    }

    public bool ValidatePriceAgainstPurchaseRate
    {
        get
        {
            return Convert.ToBoolean(Convert.ToInt16(dbContext.Singles.Where(s => s.Field.Equals("validate_price_against_purchase_rate") && s.Doctype.Equals(Doctype)).Select(s => s.Value).FirstOrDefault()));
        }
    }

    public bool EnableCashierTerminal
    {
        get
        {
            return Convert.ToBoolean(Convert.ToInt16(dbContext.Singles.Where(s => s.Field.Equals("enable_cashier_terminal") && s.Doctype.Equals(Doctype)).Select(s => s.Value).FirstOrDefault()));
        }
    }

    public bool IsCustomerRequiredInPos
    {
        get
        {
            return Convert.ToBoolean(Convert.ToInt16(dbContext.Singles.Where(s => s.Field.Equals("is_customer_required_in_pos") && s.Doctype.Equals(Doctype)).Select(s => s.Value).FirstOrDefault()));
        }
    }

    public bool EnableFiscalizing
    {
        get
        {
            return Convert.ToBoolean(Convert.ToInt16(dbContext.Singles.Where(s => s.Field.Equals("enable_fiscalizing") && s.Doctype.Equals(Doctype)).Select(s => s.Value).FirstOrDefault()));
        }
    }

    public bool PrintFooterImageInPos
    {
        get
        {
            return Convert.ToBoolean(Convert.ToInt16(dbContext.Singles.Where(s => s.Field.Equals("print_footer_image_in_pos_receipt") && s.Doctype.Equals(Doctype)).Select(s => s.Value).FirstOrDefault()));
        }
    }

    public decimal MaximumDiscount
    {
        get
        {
            return Convert.ToDecimal(dbContext.Singles.Where(s => s.Field.Equals("maximum_discount") && s.Doctype.Equals(Doctype)).Select(s => s.Value).FirstOrDefault());
        }
    }

    public int UnSettledRefreshTime
    {
        get
        {
            return Convert.ToInt32(dbContext.Singles.Where(s => s.Field.Equals("unsettled_refresh_time") && s.Doctype.Equals(Doctype)).Select(s => s.Value).FirstOrDefault());
        }
    }
}