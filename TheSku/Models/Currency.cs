using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

[Table("tabCurrency")]
public class Currency
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
    [Required]
    [Column("currency_name")]
    public string CurrencyName { get; set; }
    [Column("enabled")]
    public bool Enabled { get; set; } = true;
    [MaxLength(255)]
    [Column("fraction")]
    public string Fraction { get; set; }
    [MaxLength(255)]
    [Column("fraction_units")]
    public string FractionUnits { get; set; }
    [Column("smallest_currency_fraction_value", TypeName = "decimal(21,9)")]
    public decimal SmallestCurrencyFractionValue { get; set; }
    [MaxLength(255)]
    [Column("symbol")]
    public string Symbol { get; set; }
}