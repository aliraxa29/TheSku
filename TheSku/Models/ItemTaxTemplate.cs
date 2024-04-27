using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using Telerik.Windows.Documents.Fixed.Model.Editing.Lists;
using TheSku.Data;
using System.Linq;
using System.Collections.Generic;

[Table("tabItem Tax Template")]
public class ItemTaxTemplate
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
    [Column("title")]
    public string Title { get; set; }
    [MaxLength(255)]
    [Column("company")]
    public Company Company { get; set; }
    [Column("disabled")]
    public bool Disabled { get; set; } = false;
    public List<ItemTaxTemplateDetail> ItemTaxTemplateDetails { get; set; }
}