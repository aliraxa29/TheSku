using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
[Table("tabWarehouse")]
public class Warehouse
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
    [Column("warehouse_name")]
    public string WarehouseName { get; set; }
    [MaxLength(255)]
    [Column("parent_warehouse")]
    public string ParentWarehouse { get; set; }
    [Column("is_group")]
    public bool IsGroup { get; set; } = false;
    [Column("is_franchise")]
    public bool IsFranchise { get; set; } = false;
    [Column("disabled")]
    public bool Disabled { get; set; } = false;
    [MaxLength(255)]
    [Column("company")]
    public Company Company { get; set; }
    [MaxLength(255)]
    [Column("account")]
    public Account Account { get; set; }
    [MaxLength(255)]
    [Column("email_address")]
    public string EmailAddress { get; set; }
    [MaxLength(255)]
    [Column("phone_no")]
    public string PhoneNo { get; set; }
    [Column("address_line_1")]
    public string AddressLine1 { get; set; }
    [Column("address_line_2")]
    public string AddressLine2 { get; set; }
    [MaxLength(255)]
    [Column("city")]
    public string City { get; set; }
    [MaxLength(255)]
    [Column("state")]
    public string State { get; set; }
    [MaxLength(255)]
    [Column("pin")]
    public string Pin { get; set; }
    [MaxLength(255)]
    [Column("cost_center")]
    public CostCenter CostCenter { get; set; }
}