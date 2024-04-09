using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

[Table("tabCompany")]
public class Company
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
    [Required]
    [Column("company_name")]
    public string CompanyName { get; set; }
    [MaxLength(255)]
    [Column("abbr")]
    public string Abbrivation { get; set; }
    [MaxLength(255)]
    [Column("country")]
    public Country Country { get; set; } 
    [MaxLength(255)]
    [Column("tax_id")]
    public string TaxID { get; set; }
    [Column("date_of_establishment", TypeName = "DATE")]
    public DateTime? DateOfEstablishment { get; set; }
    [Column("date_of_incorporation", TypeName = "DATE")]
    public DateTime? DateOfIncorporation { get; set; }
    [MaxLength(255)]
    [Column("fax")]
    public string Fax { get; set; }
    [MaxLength(255)]
    [Column("phone_no")]
    public string PhoneNo { get; set; }
    [MaxLength(255)]
    [DataType(DataType.EmailAddress)]
    [Column("email_address")]
    public string EmailAddress { get; set; }
    [MaxLength(255)]
    [Column("website")]
    public string Website { get; set; }
    [Column("company_description")]
    public string CompanyDescription { get; set; }
    [MaxLength(255)]
    [Column("coa_based_on")]
    public string CoaBasedOn { get; set; }
    [MaxLength(255)]
    [Column("coa_template")]
    public string CoaTemplate { get; set; }
    [MaxLength(255)]
    [Column("existing_company")]
    public string ExistingCompany { get; set; }
    [MaxLength(255)]
    [Column("company_currency")]
    public Currency Currency { get; set; }
}