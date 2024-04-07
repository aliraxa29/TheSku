using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("tabUser")]
public class User
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
    [Column("first_name")]
    public string FirstName { get; set; }
    [MaxLength(255)]
    [Column("last_name")]
    public string LastName { get; set; }
    [MaxLength(255)]
    [Column("full_name")]
    public string FullName { get; set; }
    [Required]
    [MaxLength(255)]
    [Column("user_name")]
    public string UserName { get; set; }
    [Required]
    [Column("password")]
    public string Password { get; set; }
}
