using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

[Table("tabParty Accuount")]
public class PartyAccount
{
    [Key]
    [Column("name")]
    public int Name { get; set; }
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
    public Supplier Parent { get; set; }
    [Column("company")]
    public string Comapny { get; set; }
    [Column("account")]
    public string Account { get; set; }
}