using System;
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
        if (!string.IsNullOrWhiteSpace(doctype))
        {
            //var s = Db.Con.Query("tabUser Permission").Select("read").Where(new { document_type = doctype, role = Role }).FirstOrDefault();
            //if (s != null)
            //{
            //    return Convert.ToBoolean(s.read);
            //}
        }
        return false;
    }
    
    public bool HasCreatePermission(string doctype)
    {
        if (doctype != "")
        {
            //var s = Db.Con.Query("tabUser Permission").Select("create").Where(new { document_type = doctype, role = Role }).FirstOrDefault();
            //if (s != null)
            //{
            //    return Convert.ToBoolean(s.create);
            //}
        }
        return false;
    }

    public bool HasWritePermission(string doctype)
    {
        if (doctype!= "")
        {
            //var s = Db.Con.Query("tabUser Permission").Select("write").Where(new { document_type = doctype, role = Role }).FirstOrDefault();
            //if (s != null)
            //{
            //    return Convert.ToBoolean(s.write);
            //}
        }
        return false;
    }


    public bool HasSubmitPermission(string doctype)
    {
        if (doctype != "")
        {
            //var s = Db.Con.Query("tabUser Permission").Select("submit").Where(new { document_type = doctype, role = Role }).FirstOrDefault();
            //if (s != null)
            //{
            //    return Convert.ToBoolean(s.submit);
            //}
        }
        return false;
    }
    
    public bool HasDeletePermission(string doctype)
    {
        if (doctype != "")
        {
            //var s = Db.Con.Query("tabUser Permission").Select("delete").Where(new { document_type = doctype, role = Role }).FirstOrDefault();
            //if (s != null)
            //{
            //    return Convert.ToBoolean(s.delete);
            //}
        }
        return false;
    }
    
    public bool HasCancelPermission(string doctype)
    {
        if (doctype != "")
        {
            //var s = Db.Con.Query("tabUser Permission").Select("cancel").Where(new { document_type = doctype, role = Role }).FirstOrDefault();
            //if (s != null)
            //{
            //    return Convert.ToBoolean(s.cancel);
            //}
        }
        return false;
    }

    public static string Role { get; set; }

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