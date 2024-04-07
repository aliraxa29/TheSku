using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("tabCountry")]
public class Country
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
    [Column("country_name")]
    public string CountryName { get; set; }
    [MaxLength(255)]
    [Column("date_format")]
    public string DateFormat { get; set; }
    [MaxLength(255)]
    [Column("time_format")]
    public string TimeFormat { get; set; }
    [Column("time_zones")]
    public string TimeZones { get; set; }
    [MaxLength(255)]
    [Column("code")]
    public string Code { get; set; }
}