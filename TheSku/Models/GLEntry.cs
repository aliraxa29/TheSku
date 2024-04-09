using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

/// <summary>
/// All Transactions will be recorded in this table. Any Accounting report will be generated from this table.
/// </summary>
[Table("tabGl Entry")]
public class GLEntry
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
    [Column("posting_date", TypeName = "DATE")]
    public DateTime PostingDate { get; set; }
    [Column("transaction_date", TypeName = "DATE")]
    public DateTime TransactionDate { get; set; }
    [MaxLength(255)]
    [Column("account")]
    public Account Account { get; set; }
    [MaxLength(255)]
    [Column("party_type")]
    public string PartyType { get; set; }
    [MaxLength(255)]
    [Column("party")]
    public string Party { get; set; }
    [MaxLength(255)]
    [Column("cost_center")]
    public CostCenter CostCenter { get; set; }
    [Column("debit", TypeName = "decimal(21,9)")]
    public decimal Debit { get; set; }
    [Column("credit", TypeName = "decimal(21,9)")]
    public decimal Credit { get; set; }
    [MaxLength(255)]
    [Column("account_currency")]
    public Currency Currency { get; set; }
    [MaxLength(255)]
    [Column("against_account")]
    public Account AgainstAccount { get; set; }
    [MaxLength(255)]
    [Column("against_voucher_type")]
    public string AgainstVoucherType { get; set; }
    [MaxLength(255)]
    [Column("against_voucher")]
    public string AgainstVoucher { get; set; }
    [MaxLength(255)]
    [Column("voucher_type")]
    public string VoucherType { get; set; }
    [MaxLength(255)]
    [Column("voucher_no")]
    public string VoucherNo { get; set; }
    [Column("remarks")]
    public string Remarks { get; set; }
    [Column("is_opening")]
    public bool IsOpening { get; set; }
    [Column("is_advance")]
    public bool IsAdvance { get; set; }
    [MaxLength(255)]
    [Column("fiscal_year")]
    public FiscalYear FiscalYear { get; set; }
    [MaxLength(255)]
    [Column("fiscal_year")]
    public FinanceBook FinanceBook { get; set; }
    [Column("is_cancelled")]
    public bool IsCancelled { get; set; }
}