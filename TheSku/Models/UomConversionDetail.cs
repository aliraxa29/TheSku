using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

[Table("tabUom Conversion Detail")]
public class UomConversionDetail
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
    [Column("idx")]
    public int Index { get; set; }
    [MaxLength(255)]
    [Column("item_code")]
    public string ItemCode { get; set; }
    [MaxLength(255)]
    [Column("uom")]
    public Uom Uom { get; set; }
    [Column("conversion_factor", TypeName = "DECIMAL(21,9)")]
    public decimal ConversionFactor { get; set; } = 1;
}