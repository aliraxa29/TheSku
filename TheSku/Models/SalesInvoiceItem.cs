using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

[Table("tabSales Invoice Item")]
public class SalesInvoiceItem
{
    [Key]
    [Column("name")]
    public Guid Name { get; set; }
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
    [Column("sales_invoice_no")]
    public SalesInvoice SalesInvoice { get; set; }
    [Column("idx")]
    public int Index { get; set; } = 0;
    [MaxLength(255)]
    [Column("barcode")]
    public string Barcode { get; set; }
    [MaxLength(255)]
    [Column("item_code")]
    public Item ItemCode { get; set; }
    [MaxLength(255)]
    [Column("item_name")]
    public string ItemName { get; set; }
    [Column("description")]
    public string Description { get; set; }
    [MaxLength(255)]
    [Column("item_group")]
    public ItemGroup ItemGroup { get; set; }
    [MaxLength(255)]
    [Column("item_group")]
    public Brand Brand { get; set; }
    [Column("image")]
    public string Image { get; set; }
    [MaxLength(255)]
    [Column("packing_type")]
    public PackingType PackingType { get; set; }
    [MaxLength(255)]
    [Column("packing")]
    public string Packing { get; set; }
    [Column("qty", TypeName = "DECIMAL(21,9)")]
    public decimal Qty { get; set; } = 0;
    [MaxLength(255)]
    [Column("stock_uom")]
    public Uom StockUom { get; set; }
    [MaxLength(255)]
    [Column("uom")]
    public Uom Uom { get; set; }
    [Column("conversion_factor", TypeName = "DECIMAL(21,9)")]
    public decimal ConversionFactor { get; set; } = 1;
    [Column("stock_qty", TypeName = "DECIMAL(21,9)")]
    public decimal StockQty { get; set; } = 0;
    [Column("price_list_rate", TypeName = "DECIMAL(21,9)")]
    public decimal PriceListRate { get; set; } = 0;
    [Column("base_price_list_rate", TypeName = "DECIMAL(21,9)")]
    public decimal BasePriceListRate { get; set; } = 0;
    [Column("total", TypeName = "DECIMAL(21,9)")]
    public decimal Total { get; set; } = 0;
    [Column("discount_percentage", TypeName = "DECIMAL(21,9)")]
    public decimal DiscountPercentage { get; set; } = 0;
    [Column("discount_amount", TypeName = "DECIMAL(21,9)")]
    public decimal DiscountAmount { get; set; } = 0;
    [Column("rate", TypeName = "DECIMAL(21,9)")]
    public decimal Rate { get; set; } = 0;
    [Column("amount", TypeName = "DECIMAL(21,9)")]
    public decimal Amount { get; set; } = 0;
    [MaxLength(255)]
    [Column("item_tax_template")]
    public ItemTaxTemplate ItemTaxTemplate { get; set; }
    [Column("tax_amount", TypeName = "DECIMAL(21,9)")]
    public decimal TaxAmount { get; set; } = 0;
    [Column("base_rate", TypeName = "DECIMAL(21,9)")]
    public decimal BaseRate { get; set; } = 0;
    [Column("base_amount", TypeName = "DECIMAL(21,9)")]
    public decimal BaseAmount { get; set; } = 0;
    [Column("stock_uom_rate", TypeName = "DECIMAL(21,9)")]
    public decimal StockUomRate { get; set; } = 0;
    [Column("net_rate", TypeName = "DECIMAL(21,9)")]
    public decimal NetRate { get; set; } = 0;
    [Column("net_amount", TypeName = "DECIMAL(21,9)")]
    public decimal NetAmount { get; set; } = 0;
    [Column("base_net_rate", TypeName = "DECIMAL(21,9)")]
    public decimal BaseNetRate { get; set; } = 0;
    [Column("base_net_amount", TypeName = "DECIMAL(21,9)")]
    public decimal BaseNetAmount { get; set; } = 0;
    [MaxLength(255)]
    [Column("income_account")]
    public Account IncomeAccount { get; set; }
    [MaxLength(255)]
    [Column("finance_book")]
    public FinanceBook FinanceBook { get; set; }
    [MaxLength(255)]
    [Column("expense_account")]
    public Account ExpenseAccount { get; set; }
    [MaxLength(255)]
    [Column("warehouse")]
    public Warehouse Warehouse { get; set; }
    [MaxLength(255)]
    [Column("batch_no")]
    public string BatchNo { get; set; }
    [Column("expiry_date", TypeName = "DATE")]
    public DateTime? ExpiryDate { get; set; }
    [Column("incoming_rate", TypeName = "DECIMAL(21,9)")]
    public decimal IncomingRate { get; set; } = 0;
    [Column("is_settled")]
    public bool IsSettled { get; set; } = false;
    [MaxLength(255)]
    [Column("doctor_name")]
    public string DoctorName { get; set; }
    [MaxLength(255)]
    [Column("rack_location")]
    public string RackLocation { get; set; }
    [Column("posting_date", TypeName = "DATE")]
    public DateTime? PostingDate { get; set; }
    [Column("posting_time", TypeName = "TIME")]
    public DateTime? PostingTime { get; set; }
}