using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("tabSupplier Group")]
public class SupplierGroup
{
    [MaxLength(255)]
    [Required]
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
    [Column("docstatus")]
    public int Docstatus { get; set; }
    [MaxLength(255)]
    [Column("supplier_group_name")]
    public string SupplierGroupName { get; set; }

}