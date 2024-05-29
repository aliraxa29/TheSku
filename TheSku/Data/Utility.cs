using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using TheSku.Data;

/// <summary>
/// A utility class providing multiple utility functions in whole application.
/// </summary>
public class Utility
{

    /// <summary>
    /// Returns the current timestamp from the database server.
    /// </summary>
    public static DateTime Now
    {
        get
        {
            using (var dbContext = new AppDbContext(DbContextOptionsProvider.Options))
            {
                return dbContext.Database.SqlQuery<DateTime>($"SELECT CURRENT_TIMESTAMP(6);").FirstOrDefault();
            }
        }
    }

    /// <summary>
    /// Convert Datetime value to time ago string
    /// </summary>
    /// <param name="inputDateTime">Value to convert</param>
    /// <returns></returns>
    public static string TimeSpan(string inputDateTime)
    {
        TimeSpan timeDifference = new TimeSpan();
        if (DateTime.TryParse(inputDateTime, out DateTime dt))
        {
            timeDifference = DateTime.Now - dt;
        }
        else
        {
            return "";
        }
        if (timeDifference.TotalSeconds < 1)
        {
            return "Just Now";
        }
        else if (timeDifference.TotalSeconds < 60)
        {
            int seconds = (int)timeDifference.TotalSeconds;
            return $"{seconds} Second{(seconds != 1 ? "s" : "")} ago";
        }
        else if (timeDifference.TotalMinutes < 60)
        {
            int minutes = (int)timeDifference.TotalMinutes;
            return $"{minutes} Minute{(minutes != 1 ? "s" : "")} ago";
        }
        else if (timeDifference.TotalHours < 24)
        {
            int hours = (int)timeDifference.TotalHours;
            return $"{hours} Hour{(hours != 1 ? "s" : "")} ago";
        }
        else if (timeDifference.TotalDays < 7)
        {
            int days = (int)timeDifference.TotalDays;
            return $"{days} Day{(days != 1 ? "s" : "")} ago";
        }
        else if (timeDifference.TotalDays < 30)
        {
            int weeks = (int)(timeDifference.TotalDays / 7);
            return $"{weeks} Week{(weeks != 1 ? "s" : "")} ago";
        }
        else if (timeDifference.TotalDays < 365)
        {
            int months = (int)(timeDifference.TotalDays / 30);
            return $"{months} Month{(months != 1 ? "s" : "")} ago";
        }
        else
        {
            int years = (int)(timeDifference.TotalDays / 365);
            return $"{years} Year{(years != 1 ? "s" : "")} ago";
        }
    }
}