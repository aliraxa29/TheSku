using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TheSku.Data;

public class DbUser
{
    AppDbContext dbContext;

    public DbUser(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public List<Item> GetItems(string filter)
    {
        var query = dbContext.Item.Where(i => !i.Disabled && i.IsSaleItem && i.IsStockItem);
        if (!string.IsNullOrEmpty(filter))
        {
            query = query.Where(i =>
                EF.Functions.Like(i.Name, string.Concat(filter, "%")) ||
                EF.Functions.Like(i.ItemName, string.Concat(filter, "%")));
        }
        var items = query.Select(i => new Item
        {
            Name = i.Name,
            ItemName = i.ItemName,
            Description = i.Description
        }).Take(50).ToList();
        return items;
    }

}