using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using TheSku.Data;
using System.Linq;

/// <summary>
/// Contains the information about primary key value of the each naming series.
/// </summary>
[Table("tabSeries")]
public class Series
{
    [Key]
    [Required]
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
    [Column("current")]
    public int Current { get; set; } = 0;


    public static int GetNextSeriesNumber(AppDbContext dbContext, string series)
    {
        Series series1 = dbContext.Series.Where(s => s.Name.Equals(series)).FirstOrDefault();
        if (series1 == null)
        {
            series1 = new Series();
            series1.Creation = DateTime.Now;
            series1.Owner = Global.UserName;
            series1.Name = series;
            series1.Current = 1;
            dbContext.Series.Add(series1);
            dbContext.SaveChanges();
            return 1;
        }
        else
        {
            series1.Current = series1.Current + 1;
            dbContext.Series.Add(series1);
            dbContext.SaveChanges();
            return series1.Current;
        }
    }
}