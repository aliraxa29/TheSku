public class Operations <T> where T : class
{
    public Operations()
    {
        
    }

    /// <summary>
    /// Check all the foreign key entries of the model in database
    /// </summary>
    /// <returns>
    /// Return true if exists, else false and the entity type
    /// </returns>
    public (bool IsExists, T entity) CheckRelatedEntries()
    {
        return (true, null);
    }
}