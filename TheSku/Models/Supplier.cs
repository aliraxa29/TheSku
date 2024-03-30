using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Supplier
{
    [Column("name")]
    [Key]
    public string Name { get; set; }
    [Column("creation")]
    public DateTime Creation { get; set; } = DateTime.Now;
    [Column("modified")]
    public DateTime Modified { get; set; } = DateTime.Now;
    [Column("modified_by")]
    public string ModifiedBy { get; set; }
    [Column("owner")]
    public string Owner { get; set; }
    [Required]
    [Column("supplier_name")]
    public string SupplierName { get; set; }
}