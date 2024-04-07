using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

[Table("tabCustomer Credit Limit")]
public class CustomerCreditLimit
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
    [MaxLength(1)]
    [Column("docstatus")]
    public int Docstatus { get; set; }
    [MaxLength(255)]
    [Column("company")]
    public string Comapny { get; set; }
    [Column("credit_limit", TypeName = "decimal(21,9)")]
    public decimal CreditLimit { get; set; } = 0;
    [MaxLength(1)]
    [Column("bypass_credit_check")]
    public int BypassCreditCheck { get; set; }
}