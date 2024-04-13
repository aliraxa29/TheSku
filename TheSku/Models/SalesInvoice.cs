using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

[Table("tabSales Invoice")]
public class SalesInvoice
{
    [MaxLength(255)]
    [Key]
    [Column("name")]
    public string Name { get; set; }
    [Column("creation")]
    public DateTime Creation { get; set; }
    [Column("modified")]
    public DateTime Modified { get; set; } = DateTime.Now;
    [MaxLength(255)]
    [Column("modified_by")]
    public string ModifiedBy { get; set; } = Global.UserName;
    [MaxLength(255)]
    [Column("owner")]
    public string Owner { get; set; }
    [MaxLength(1)]
    [Column("docstatus")]
    public int Docstatus { get; set; } = 0;
    [MaxLength(255)]
    [Column("fiscal_invoice_no")]
    public string FiscalInvoiceNo { get; set; }
    [Column("fiscal_invoice_date")]
    public DateTime? FiscalInvoiceDate { get; set; }
    [MaxLength(255)]
    [Column("customer")]
    public Customer Customer { get; set; }
    [MaxLength(255)]
    [Column("tax_id")]
    public string TaxId { get; set; }
    [MaxLength(255)]
    [Column("patient_name")]
    public string PatientName { get; set; }
    [MaxLength(255)]
    [Column("pos_profile")]
    public PosProfile PosProfile { get; set; }
    [Column("is_pos")]
    public bool IsPos { get; set; } = false;
    [Column("is_consolidated")]
    public bool IsConsolidated { get; set; } = false;
    [Column("is_return")]
    public bool IsReturn { get; set; } = false;
    [MaxLength(255)]
    [Column("company")]
    public Company Company { get; set; }
    [MaxLength(255)]
    [Column("company_tax_id")]
    public string CompanyTaxId { get; set; }
    [Column("posting_date", TypeName = "DATE")]
    public DateTime? PostingDate { get; set; }
    [Column("posting_time", TypeName = "TIME")]
    public DateTime? PostingTime { get; set; }
    [Column("set_posting_time")]
    public bool SetPostingTime { get; set; } = false;
    [Column("due_date", TypeName = "DATE")]
    public DateTime? DueDate { get; set; }
    [MaxLength(255)]
    [Column("return_against")]
    public string ReturnAgainst { get; set; }
    [MaxLength(255)]
    [Column("cost_center")]
    public CostCenter CostCenter { get; set; }
    [MaxLength(255)]
    [Column("customer_address")]
    public string CustomerAddress { get; set; }
    [MaxLength(255)]
    [Column("contact_person")]
    public string ContactPerson { get; set; }
    [MaxLength(255)]
    [Column("contact_mobile")]
    public string ContactMobile { get; set; }
    [MaxLength(255)]
    [Column("contact_email")]
    public string ContactEmail { get; set; }
    [MaxLength(255)]
    [Column("shipping_address")]
    public string ShippingAddress { get; set; }
    [MaxLength(255)]
    [Column("company_address")]
    public string CompanyAddress { get; set; }
    [MaxLength(255)]
    [Column("territory")]
    public Territory Territory { get; set; }
    [MaxLength(255)]
    [Column("currency")]
    public Currency Currency { get; set; }
    [Column("conversion_rate", TypeName = "DECIMAL(21,9)")]
    public decimal ConversionRate { get; set; } = 1;
    [Column("plc_conversion_rate", TypeName = "DECIMAL(21,9)")]
    public decimal PlcConversionRate { get; set; } = 1;
    [Column("ignore_pricing_rule")]
    public bool IgnorePricingRule { get; set; } = false;
    [Column("update_stock")]
    public bool UpdateStock { get; set; } = false;
    [MaxLength(255)]
    [Column("price_list")]
    public PriceList PriceList { get; set; }
    [Column("total_qty", TypeName = "DECIMAL(21,9)")]
    public decimal TotalQty { get; set; } = 0;
    [Column("base_total", TypeName = "DECIMAL(21,9)")]
    public decimal BaseTotal { get; set; } = 0;
    [Column("base_net_total", TypeName = "DECIMAL(21,9)")]
    public decimal BaseNetTotal { get; set; } = 0;
    [Column("total", TypeName = "DECIMAL(21,9)")]
    public decimal Total { get; set; } = 0;
    [Column("net_total", TypeName = "DECIMAL(21,9)")]
    public decimal NetTotal { get; set; } = 0;
    [Column("total_taxes_charges", TypeName = "DECIMAL(21,9)")]
    public decimal TotalTaxesCharges { get; set; } = 0;
    [Column("loyalty_points", TypeName = "DECIMAL(21,9)")]
    public decimal LoyaltyPoints { get; set; } = 0;
    [Column("loyalty_amount", TypeName = "DECIMAL(21,9)")]
    public decimal LoyaltyAmount { get; set; } = 0;
    [Column("redeem_loyalty_points")]
    public bool RedeemLoyaltyPoints { get; set; } = false;
    [MaxLength(255)]
    [Column("loyalty_program")]
    public LoyaltyProgram LoyaltyProgram { get; set; }
    [MaxLength(255)]
    [Column("loyalty_redemption_account")]
    public Account LoyaltyRedemptionAccount { get; set; }
    [MaxLength(255)]
    [Column("loyalty_redemption_cost_center")]
    public CostCenter LoyaltyRedemptionCostCenter { get; set; }
    [Column("additional_discount_percentage", TypeName = "DECIMAL(21,9)")]
    public decimal AdditionalDiscountPercentage { get; set; } = 0;
    [Column("discount_amount", TypeName = "DECIMAL(21,9)")]
    public decimal DiscountAmount { get; set; } = 0;
    [Column("base_grand_total", TypeName = "DECIMAL(21,9)")]
    public decimal BaseGrandTotal { get; set; } = 0;
    [Column("base_rounding_adjustment", TypeName = "DECIMAL(21,9)")]
    public decimal BaseRoundingAdjustment { get; set; } = 0;
    [Column("base_rounded_total", TypeName = "DECIMAL(21,9)")]
    public decimal BaseRoundedTotal { get; set; } = 0;
    [Column("base_in_words", TypeName = "TEXT")]
    public string BaseInWords { get; set; }
    [Column("grand_total", TypeName = "DECIMAL(21,9)")]
    public decimal GrandTotal { get; set; } = 0;
    [Column("rounding_adjustment", TypeName = "DECIMAL(21,9)")]
    public decimal RoundingAdjustment { get; set; } = 0;
    [Column("rounded_total", TypeName = "DECIMAL(21,9)")]
    public decimal RoundedTotal { get; set; } = 0;
    [Column("in_words", TypeName = "TEXT")]
    public string InWords { get; set; }
    [Column("total_advance", TypeName = "DECIMAL(21,9)")]
    public decimal TotalAdvance { get; set; } = 0;
    [Column("outstanding_amount", TypeName = "DECIMAL(21,9)")]
    public decimal OutstandingAmount { get; set; } = 0;
    [Column("disable_rounded_total")]
    public bool DisableRoundedTotal { get; set; } = false;
    [Column("base_paid_amount", TypeName = "DECIMAL(21,9)")]
    public decimal BasePaidAmount { get; set; } = 0;
    [Column("paid_amount", TypeName = "DECIMAL(21,9)")]
    public decimal PaidAmount { get; set; } = 0;
    [Column("base_change_amount", TypeName = "DECIMAL(21,9)")]
    public decimal BaseChangeAmount { get; set; } = 0;
    [Column("change_amount", TypeName = "DECIMAL(21,9)")]
    public decimal ChangeAmount { get; set; } = 0;
    [Column("account_for_change_amount", TypeName = "VARCHAR(255)")]
    public string AccountForChangeAmount { get; set; }
    [Column("status", TypeName = "VARCHAR(255)")]
    public string Status { get; set; }
    [MaxLength(255)]
    [Column("debit_to")]
    public Account DebitTo { get; set; }
    [MaxLength(255)]
    [Column("party_account_currency")]
    public Currency PartyAccountCurrency { get; set; }
    [Column("remarks", TypeName = "TEXT")]
    public string Remarks { get; set; }
    [MaxLength(255)]
    [Column("against_income_account")]
    public Account AgainstIncomeAccount { get; set; }
    [Column("total_items")]
    public int TotalItems { get; set; } = 0;
    [Column("print_count")]
    public int PrintCount { get; set; } = 0;
    public List<SalesInvoiceItem> SalesInvoiceItems { get; set; }
}