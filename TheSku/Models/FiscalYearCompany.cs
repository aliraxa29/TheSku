using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

[Table("tabFiscal Year Company")]
public class FiscalYearCompany
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
    [Column("idx")]
    public string Index { get; set; }
    [MaxLength(255)]
    [Column("fiscal_year")]
    public FiscalYear FiscalYear { get; set; }
    [MaxLength(255)]
    [Column("company")]
    public Company Company { get; set; }
}