using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

[Table("tabFiscal Year")]
public class FiscalYear
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
    [Column("fiscal_year_name")]
    public string FiscalYearName { get; set; }
    [Column("disabled")]
    public bool Disabled { get; set; }
    [Column("is_short_year")]
    public bool IsShortYear { get; set; }
    [Column("year_start_date", TypeName = "DATE")]
    public DateTime? YearStartDate { get; set; }
    [Column("year_end_date", TypeName = "DATE")]
    public DateTime? YearEndDate { get; set; }

}