using System;
using TheSku.Data;

public class TransactionService
{
    private readonly AppDbContext dbContext;

    public TransactionService(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public bool ExecuteTransaction(params object[] entities)
    {
        using (var transaction = dbContext.Database.BeginTransaction())
        {
            try
            {
                foreach (var entity in entities)
                {
                    dbContext.Add(entity);
                }
                dbContext.SaveChanges();
                transaction.Commit();

                return true;
            }
            catch (Exception)
            {
                transaction.Rollback();
                return false;
            }
        }
    }
}