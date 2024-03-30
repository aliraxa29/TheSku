using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User
{
    [Column("name")]
    [Key]
    public Guid Name { get; set; }
    [Required]
    [Column("user_name")]
    public string UserName { get; set; }
    [Required]
    [Column("password")]
    public string Password { get; set; }
}
