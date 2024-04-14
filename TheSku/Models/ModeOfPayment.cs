using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

[Table("tabMode Of Payment")]
public class ModeOfPayment
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
    [Column("mode_of_payment_name")]
    public string ModeOfPaymentName { get; set; }
    [Column("enabled")]
    public bool Enabled { get; set; } = true;
    [MaxLength(255)]
    [Column("type")]
    public string Type { get; set; }
}