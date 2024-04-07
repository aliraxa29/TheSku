using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

[Table("tabAccount")]
public class Account
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
    [Column("disabled")]
    public int Disabled { get; set; }
    [MaxLength(255)]
    [Required]
    [Column("account_name")]
    public string AccountName { get; set; }
    [MaxLength(255)]
    [Column("account_number")]
    public string AccountNumber { get; set; }
    [MaxLength(1)]
    [Column("is_group")]
    public int IsGroup { get; set; }
    [MaxLength(255)]
    [Column("company")]
    public string Company { get; set; }
    [MaxLength(255)]
    [Column("root_type")]
    public string RootType { get; set; }
    [MaxLength(255)]
    [Column("report_type")]
    public string ReportType { get; set; }
    [MaxLength(255)]
    [Column("account_currency")]
    public string AccountCurrency { get; set; }
    [MaxLength(255)]
    [Column("parent_account")]
    public string ParentAccount { get; set; }
    [MaxLength(255)]
    [Column("account_type")]
    public string AccountType { get; set; }
    [Column("tax_rate", TypeName = "decimal(21,9)")]
    public decimal TaxRate { get; set; }
    [MaxLength(1)]
    [Column("freeze_account")]
    public int FreezeAccount { get; set; }
    [MaxLength(255)]
    [Column("balance_must_be")]
    public string BalanceMustBe { get; set; }
}