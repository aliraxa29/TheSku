using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("tabSupplier")]
public class Supplier
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
    [Required]
    [Column("supplier_name")]
    public string SupplierName { get; set; }
    [Required]
    [Column("supplier_group")]
    public string SupplierGroup { get; set; }
    [Column("supplier_type")]
    public string SupplierType { get; set; }
    [Column("supplier_details")]
    public string SupplierDetails { get; set; }
    [Column("tax_id")]
    public string TaxID { get; set; }
    [Column("primary_address")]
    public string PrimaryAddress { get; set; }
    [Column("primary_contact")]
    public string PrimaryContact { get; set; }
    [Column("accounts")]
    public List<PartyAccount> PartyAccounts { get; set; }
    [Column("disabled")]
    public int Disabled { get; set; }
    [Column("block_supplier")]
    public int BlockSupplier { get; set; }
}