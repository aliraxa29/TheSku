using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

public class Item
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
    [Column("item_code")]
    public string ItemCode { get; set; }
    [MaxLength(255)]
    [Column("item_name")]
    public string ItemName { get; set; }
    [MaxLength(255)]
    [Column("item_group")]
    public ItemGroup ItemGroup { get; set; }
    [MaxLength(255)]
    [Column("stock_uom")]
    public Uom StockUom { get; set; }
    [Column("disabled")]
    public bool Disabled { get; set; } = false;
    [Column("is_stock_item")]
    public bool IsStockItem { get; set; } = false;
    [Column("opening_stock", TypeName = "DECIMAL(21,9)")]
    public decimal OpeningStock { get; set; } = 0;
    [Column("valuation_rate", TypeName = "DECIMAL(21,9)")]
    public decimal ValuationRate { get; set; } = 0;
    [Column("standard_rate", TypeName = "DECIMAL(21,9)")]
    public decimal StandardRate { get; set; } = 0;
    [Column("image")]
    public string Image { get; set; }
    [MaxLength(255)]
    [Column("brand")]
    public Brand Brand { get; set; }
    [Column("description")]
    public string Description { get; set; }
    [Column("allow_negative_stock")]
    public bool AllowNegativeStock { get; set; } = false;
    [Column("is_purchase_item")]
    public bool IsPurchaseItem { get; set; } = false;
    [Column("is_sales_item")]
    public bool IsSaleItem { get; set; } = false;
    [MaxLength(255)]
    [Column("packing_type")]
    public PackingType PackingType { get; set; }
    [MaxLength(255)]
    [Column("packing")]
    public string Packing { get; set; }
    [Column("is_fridge_item")]
    public bool IsFridgeItem { get; set; } = false;
    [Column("is_narcotic_item")]
    public bool IsNarcoticItem { get; set; } = false;
    [Column("is_short_item")]
    public bool IsShortItem { get; set; } = false;
    [Column("is_non_returnable")]
    public bool IsNonReturnableItem { get; set; } = false;
    [Column("generic_name")]
    public string GenericName { get; set; }
    [MaxLength(255)]
    [Column("rack_location")]
    public string RackLocation { get; set; }
    [Column("is_near_expiry")]
    public bool IsNearExpiryItem { get; set; } = false;
}