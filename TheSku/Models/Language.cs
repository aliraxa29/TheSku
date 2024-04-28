using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
[Table("tabLanguage")]
public class Language
{
    [MaxLength(255)]
    [Key]
    public string Name { get; set; }
    [Column("creation")]
    public DateTime Creation { get; set; } = DateTime.Now;
    [Column("modified")]
    public DateTime Modified { get; set; }
    [MaxLength(255)]
    [Column("modified_by")]
    public string ModifiedBy { get; set; }
    [MaxLength(255)]
    [Column("owner")]
    public string Owner { get; set; } = Global.UserName;
    [Column("enabled")]
    public bool Enabled { get; set; } = true;
    [MaxLength(255)]
    [Column("language_code")]
    public string LanguageCode { get; set; }
    [MaxLength(255)]
    [Column("language_name")]
    public string LanguageName { get; set; }
    [MaxLength(255)]
    [Column("flag")]
    public string Flag { get; set; }
}