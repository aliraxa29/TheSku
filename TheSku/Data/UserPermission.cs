using System;
using System.Linq;
using TheSku.Data;

public class UserPermissions
{
    AppDbContext dbContext;

    public UserPermissions(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }


    public bool HasReadPermission(string doctype)
    {
        return dbContext.UserPermissions.Where(p => p.DocumentType.Equals(doctype) && p.Role == Global.User.Role).Select(p => p.Read).FirstOrDefault();
    }
    
    public bool HasCreatePermission(string doctype)
    {
        return dbContext.UserPermissions.Where(p => p.DocumentType.Equals(doctype) && p.Role == Global.User.Role).Select(p => p.Create).FirstOrDefault();
    }

    public bool HasWritePermission(string doctype)
    {
        return dbContext.UserPermissions.Where(p => p.DocumentType.Equals(doctype) && p.Role == Global.User.Role).Select(p => p.Write).FirstOrDefault();
    }


    public bool HasSubmitPermission(string doctype)
    {
        return dbContext.UserPermissions.Where(p => p.DocumentType.Equals(doctype) && p.Role == Global.User.Role).Select(p => p.Submit).FirstOrDefault();
    }
    
    public bool HasDeletePermission(string doctype)
    {
        return dbContext.UserPermissions.Where(p => p.DocumentType.Equals(doctype) && p.Role == Global.User.Role).Select(p => p.Delete).FirstOrDefault();
    }

    public bool HasCancelPermission(string doctype)
    {
        return dbContext.UserPermissions.Where(p => p.DocumentType.Equals(doctype) && p.Role == Global.User.Role).Select(p => p.Cancel).FirstOrDefault();
    }

    public bool Authenticate(string username, string password)
    {
        if (username == "" || username == null)
        {
            return false;
        }
        //if (Db.Con.Query("__Auth").Where(new { name = username, password = Security.EncryptString(password) }).Count<int>() > 0)
        //{
        //    return true;
        //}
        return false;
    }
}