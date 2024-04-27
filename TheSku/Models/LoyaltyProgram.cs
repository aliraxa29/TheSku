using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

[Table("tabLoyalty Program")]
public class LoyaltyProgram
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
    [Column("loyalty_program_name")]
    public string LoyaltyProgramName { get; set; }
    [MaxLength(255)]
    [Column("loyalty_program_type")]
    public string LoyaltyProgramType { get; set; }
    [Column("from_date", TypeName = "DATE")]
    public DateTime? FromDate { get; set; }
    [Column("to_date", TypeName = "DATE")]
    public DateTime? ToDate { get; set; }
    [MaxLength(255)]
    [Column("customer_group")]
    public string CustomerGroup { get; set; }
    [MaxLength(255)]
    [Column("customer_territory")]
    public string CustomerTerritory { get; set; }
    [Column("conversion_factor", TypeName = "DECIMAL(21,9)")]
    public decimal ConversionFactor { get; set; } = 1;
    [Column("expiry_duration", TypeName = "DECIMAL(21,9)")]
    public decimal ExpirationDuration { get; set; } = 0;
    [MaxLength(255)]
    [Column("expense_account")]
    public Account ExpenseAccount { get; set; }
    [MaxLength(255)]
    [Column("company")]
    public Company Company { get; set; }
    [MaxLength(255)]
    [Column("cost_center")]
    public CostCenter CostCenter { get; set; }
}