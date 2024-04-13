using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

public class ItemPrice
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
    [Column("item_code")]
    public Item ItemCode { get; set; }
    [MaxLength(255)]
    [Column("uom")]
    public Uom Uom { get; set; }
    [MaxLength(255)]
    [Column("item_name")]
    public string ItemName { get; set; }
    [MaxLength(255)]
    [Column("brand")]
    public Brand Brand { get; set; }
    [Column("description")]
    public string Description { get; set; }
    [MaxLength(255)]
    [Column("price_list")]
    public PriceList PriceList { get; set; }
    [MaxLength(255)]
    [Column("customer")]
    public Customer Customer { get; set; }
    [MaxLength(255)]
    [Column("supplier")]
    public Supplier Supplier { get; set; }
    [Column("selling")]
    public bool Selling { get; set; } = false;
    [Column("buying")]
    public bool Buying { get; set; } = false;
    [Column("lock_discount")]
    public bool LockDiscount { get; set; } = false;
    [MaxLength(255)]
    [Column("currency")]
    public Currency Currency { get; set; }
    [Column("price_list_rate", TypeName = "DECIMAL(21,9)")]
    public decimal PriceListRate { get; set; } = 0;
    [Column("valid_from", TypeName = "DATE")]
    public DateTime? ValidFrom { get; set; }
}