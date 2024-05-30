using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("tabSupplier")]
public class Supplier
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
    [MaxLength(255)]
    [Required]
    [Column("supplier_name")]
    public string SupplierName { get; set; }
    [MaxLength(255)]
    [Required]
    [Column("supplier_group")]
    public string SupplierGroup { get; set; }
    [MaxLength(255)]
    [Column("supplier_type")]
    public string SupplierType { get; set; }
    [Column("supplier_details")]
    public string SupplierDetails { get; set; }
    [MaxLength(255)]
    [Column("tax_id")]
    public string TaxID { get; set; }
    [Column("primary_address")]
    public string PrimaryAddress { get; set; }
    [MaxLength(255)]
    [Column("primary_contact")]
    public string PrimaryContact { get; set; }
    [Column("accounts")]
    public List<PartyAccount> PartyAccounts { get; set; }
    [Column("disabled")]
    public bool Disabled { get; set; }
    [Column("block_supplier")]
    public bool BlockSupplier { get; set; }
}