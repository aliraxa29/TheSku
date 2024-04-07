using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

[Table("tabCustomer")]
public class Customer
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
    [MaxLength(1)]
    [Column("docstatus")]
    public int Docstatus { get; set; }
    [MaxLength(255)]
    [Required]
    [Column("customer_name")]
    public string CustomerName { get; set; }
    [MaxLength(255)]
    [Required]
    [Column("customer_group")]
    public string CustomerGroup { get; set; }
    [MaxLength(255)]
    [Column("customer_type")]
    public string CustomerType { get; set; }
    [Column("customer_details")]
    public string CustomerDetails { get; set; }
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
    [MaxLength(1)]
    [Column("disabled")]
    public int Disabled { get; set; }
    [MaxLength(255)]
    [Column("phone_number")]
    public string PhoneNumber { get; set; }
}