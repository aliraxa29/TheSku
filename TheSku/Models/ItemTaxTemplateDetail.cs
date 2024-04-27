using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

[Table("tabItem Tax Template Detail")]
public class ItemTaxTemplateDetail
{
    [MaxLength(255)]
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
    [MaxLength(255)]
    [Column("item_tax_template_name")]
    public ItemTaxTemplate ItemTaxTemplate { get; set; }
    [MaxLength(255)]
    [Column("tax_type")]
    public Account TaxType { get; set; }
    [Column("tax_rate", TypeName = "DECIMAL(21,9)")]
    public decimal TaxRate { get; set; }
}