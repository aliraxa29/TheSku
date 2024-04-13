using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

public class Uom
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
    [Column("enabled")]
    public bool Enabled { get; set; } = true;
    [MaxLength(255)]
    [Column("uom_name")]
    public string UomName { get; set; }
    [Column("must_be_whole_number")]
    public bool MustBeWholeNumber { get; set; } = false;
}