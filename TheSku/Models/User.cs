using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("tabUser")]
public class User
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
    [Column("parentfield")]
    public string ParentField { get; set; }
    [Column("parenttype")]
    public string ParentType { get; set; }
    [Column("first_name")]
    public string FirstName { get; set; }
    [Column("last_name")]
    public string LastName { get; set; }
    [Column("full_name")]
    public string FullName { get; set; }
    [Required]
    [Column("user_name")]
    public string UserName { get; set; }
    [Required]
    [Column("password")]
    public string Password { get; set; }
}
