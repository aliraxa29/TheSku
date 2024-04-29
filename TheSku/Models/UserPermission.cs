using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

[Table("tabUser Permission")]
public class UserPermission
{
    [Key]
    [Column("name")]
    public Guid Name { get; set; }
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
    [Column("document_type")]
    public string DocumentType { get; set; }
    [MaxLength(255)]
    [Column("role")]
    public Role Role { get; set; }
    [Column("read")]
    public bool Read { get; set; } = true;
    [Column("write")]
    public bool Write { get; set; } = false;
    [Column("create")]
    public bool Create { get; set; } = false;
    [Column("submit")]
    public bool Submit { get; set; } = false;
    [Column("cancel")]
    public bool Cancel { get; set; } = false;
    [Column("delete")]
    public bool Delete { get; set; } = false;
}