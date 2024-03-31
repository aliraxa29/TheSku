using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User
{
    [Column("name")]
    [Key]
    public string Name { get; set; }
    [Column("creation")]
    public DateTime Creation { get; set; } = DateTime.Now;
    [Column("modified")]
    public DateTime Modified { get; set; } = DateTime.Now;
    [Column("modified_by")]
    public string ModifiedBy { get; set; }
    [Column("owner")]
    public string Owner { get; set; }
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
