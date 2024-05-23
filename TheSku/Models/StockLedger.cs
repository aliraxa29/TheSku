using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

[Table("tabStock Ledger Entry")]
public class StockLedger
{
    [Key]
    [Column("name")]
    public int Name { get; set; }
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
    [Column("item_code")]
    public Item ItemCode { get; set; }
    [MaxLength(255)]
    [Column("warehouse")]
    public Warehouse Warehouse { get; set; }
    [Column("posting_date")]
    public DateTime PostingDate { get; set; }
    [Column("posting_time")]
    public TimeSpan PostingTime { get; set; }
    [MaxLength(255)]
    [Column("voucher_type")]
    public string VoucherType { get; set; }
    [MaxLength(255)]
    [Column("voucher_no")]
    public string VoucherNo { get; set; }
    [Column("actual_qty")]
    public int ActualQty { get; set; } = 0;
    [Column("qty_after_transaction")]
    public int QtyAfterTransaction { get; set; } = 0;
    [Column("incoming_rate", TypeName = "DECIMAL(21,9)")]
    public decimal IncomingRate { get; set; } = 0;
    [Column("outgoing_rate", TypeName = "DECIMAL(21,9)")]
    public decimal OutgoingRate { get; set; } = 0;
    [Column("valuation_rate", TypeName = "DECIMAL(21,9)")]
    public decimal ValuationRate { get; set; } = 0;
    [Column("stock_value", TypeName = "DECIMAL(21,9)")]
    public decimal StockValue { get; set; } = 0;
    [Column("stock_value_difference", TypeName = "DECIMAL(21,9)")]
    public decimal StockValueDifference { get; set; } = 0;
    [MaxLength(255)]
    [Column("company")]
    public Company Company { get; set; }
    [MaxLength(255)]
    [Column("fiscal_year")]
    public FiscalYear FiscalYear { get; set; }
    [Column("is_cancelled")]
    public bool IsCancelled { get; set; } = false;

    public static void AddStockLedgerEntry()
    {

    }
}