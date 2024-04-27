using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

[Table("tabPrice List")]
public class PriceList
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
    [Column("price_list_name")]
    public string PriceListName { get; set; }
    [MaxLength(255)]
    [Column("currency")]
    public Currency Currency { get; set; }
    [Column("buying")]
    public bool Buying { get; set; } = false;
    [Column("selling")]
    public bool Selling { get; set; } = false;
    [Column("price_not_uom_dependent")]
    public bool PriceNotUomDependent { get; set; } = false;
}