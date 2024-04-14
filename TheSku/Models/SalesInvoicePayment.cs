using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;


/// <summary>
/// All payments against POS sales invoices will be recorded here.
/// </summary>
[Table("tabSales Invoice Payment")]
public class SalesInvoicePayment
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
    public int Docstatus { get; set; }
    [MaxLength(255)]
    [Column("sales_invoice")]
    public SalesInvoice SalesInvoice { get; set; }
    [Column("is_default")]
    public bool IsDefault { get; set; } = false;
    [MaxLength(255)]
    [Column("mode_of_payment")]
    public string ModeOfPayment { get; set; }
    [Column("amount", TypeName = "DECIMAL(21,9)")]
    public decimal Amount { get; set; } = 0;
    [MaxLength(255)]
    [Column("account")]
    public Account Account { get; set; }
    [MaxLength(255)]
    [Column("type")]
    public string Type { get; set; }
    [Column("base_amount", TypeName = "DECIMAL(21,9)")]
    public decimal BaseAmount { get; set; } = 0;
}