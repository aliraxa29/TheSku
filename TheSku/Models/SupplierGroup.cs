using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("tabSupplier Group")]
public class SupplierGroup
{
    [Required]
    [Key]
    [Column("name")]
    public string Name { get; set; }
    [Column("creation")]
    public DateTime Creation { get; set; }
    [Column("modified")]
    public DateTime Modified { get; set; } = DateTime.Now;
    [Column("modified_by")]
    public string ModifiedBy { get; set; } = Global.UserName;
    [Column("owner")]
    public string Owner { get; set; }
    [Column("docstatus")]
    public int Docstatus { get; set; }
    [Column("parent")]
    public string Parent { get; set; }
    [Column("parentfield")]
    public string ParentField { get; set; }
    [Column("parenttype")]
    public string ParentType { get; set; }
    [Column("supplier_group_name")]
    public string SupplierGroupName { get; set; }

}