using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

public class Bin
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
    [Column("warehouse")]
    public Warehouse Warehouse { get; set; }
    [Column("item_code")]
    public Item ItemCode { get; set; }
    [Column("actual_qty", TypeName = "DECIMAL(21,9)")]
    public decimal ActualQty { get; set; } = 0;
    [MaxLength(255)]
    [Column("stock_uom")]
    public Uom StockUom { get; set; }
    [Column("valuation_rate", TypeName = "DECIMAL(21,9)")]
    public decimal ValuationRate { get; set; } = 0;
    [Column("outgoing_rate", TypeName = "DECIMAL(21,9)")]
    public decimal OutgoingRate { get; set; } = 0;
    [Column("stock_value", TypeName = "DECIMAL(21,9)")]
    public decimal StockValue
    {
        get
        {
            return this.ValuationRate * this.ActualQty;
        }
        set
        {
            value = this.ValuationRate * this.ActualQty;
        }
    }
    [MaxLength(255)]
    [Column("batch_no")]
    public string BatchNo { get; set; }
    [MaxLength(255)]
    [Column("expiry_date")]
    public DateOnly? ExpiryDate { get; set; }
}