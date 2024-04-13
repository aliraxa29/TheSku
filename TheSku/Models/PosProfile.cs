using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using Newtonsoft.Json;

public class PosProfile
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
    [MaxLength(255)]
    [Column("pos_profile_name")]
    public string PosProfileName { get; set; }
    [MaxLength(255)]
    [Column("company")]
    public Company Company { get; set; }
    [MaxLength(255)]
    [Column("customer")]
    public Customer Customer { get; set; }
    [MaxLength(255)]
    [Column("country")]
    public Country Country { get; set; }
    [Column("disabled")]
    public bool Disabled { get; set; } = false;
    [MaxLength(255)]
    [Column("warehouse")]
    public Warehouse Warehouse { get; set; }
    [Column("company_address")]
    public string CompanyAddress { get; set; }
    [Column("validate_stock")]
    public bool ValidateStockOnSave { get; set; } = false;
    [Column("update_stock")]
    public bool UpdateStock { get; set; } = false;
    [Column("ignore_pricing_rule")]
    public bool IgnorePricingRule { get; set; } = false;
    [Column("allow_change_rate")]
    public bool AllowChangeRate { get; set; } = false;
    [Column("allow_change_discount")]
    public bool AllowChangeDiscount { get; set; } = false;
    [MaxLength(255)]
    [Column("print_format")]
    public string PrintFormat { get; set; }
    [MaxLength(255)]
    [Column("selling_price_list")]
    public PriceList PriceList { get; set; }
    [MaxLength(255)]
    [Column("currency")]
    public Currency Currency { get; set; }
    [MaxLength(255)]
    [Column("write_off_account")]
    public Account WriteOffAccount { get; set; }
    [MaxLength(255)]
    [Column("write_off_cost_center")]
    public CostCenter WriteOffCostCenter { get; set; }
    [Column("write_off_limit", TypeName = "DECIMAL(21,9)")]
    public decimal WriteOffLimit { get; set; } = 1;
    [MaxLength(255)]
    [Column("account_for_change_amount")]
    public Account AccountForChangeAmount { get; set; }
    [Column("disable_rounded_total")]
    public bool DisableRoundedTotal { get; set; } = false;
    [MaxLength(255)]
    [Column("income_account")]
    public Account IncomeAccount { get; set; }
    [MaxLength(255)]
    [Column("expense_account")]
    public Account ExpenseAccount { get; set; }
    [MaxLength(255)]
    [Column("cost_center")]
    public CostCenter CostCenter { get; set; }
    [Column("header")]
    public string ReceiptHeader { get; set; }
    [Column("footer")]
    public string ReceiptFooter { get; set; }
    [Column("additional_disocunt_limit", TypeName = "DECIMAL(21,9)")]
    public decimal AdditionalDiscountLimit { get; set; } = 0;
}