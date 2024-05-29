using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

[Table("tabItem Supplier")]
public class ItemSupplier
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
    [MaxLength(255)]
    [Column("item_code")]
    public Item ItemCode { get; set; }
    [MaxLength(255)]
    [Column("supplier")]
    public Supplier Supplier { get; set; }
}