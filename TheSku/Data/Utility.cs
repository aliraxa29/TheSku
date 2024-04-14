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
}