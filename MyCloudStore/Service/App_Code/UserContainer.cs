using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

/// <summary>
/// Summary description for UserContainer
/// </summary>
public class UserContainer
{

    public static string Putanja = @"C:\MyCloudStorage\";
    protected static object locker = false;
    protected static UserContainer instance = null;
    public static UserContainer Instance
    {
        get
        {
            lock (locker)
            {
                if(instance == null)
                {
                    instance = new UserContainer();
                }
            }
            return instance;
        }
    }
    protected UserContainer()
    {
        Database.SetInitializer(new DropCreateDatabaseIfModelChanges<UserDBContext>());
    }

    public void registerUser(string username, string password)
    {
        using (var db = new UserDBContext())
        {
            User newUser = new User();
            newUser.Username = username;
            newUser.Password = password;
            db.Users.Add(newUser);
            db.SaveChanges();
        }
        System.IO.Directory.CreateDirectory(System.IO.Path.Combine(Putanja, username));
    }

    public User getUser(string username)
    {
        using (var db = new UserDBContext())
        {
            User ret = db.Users.Where(b => b.Username == username).Include(b => b.Files).FirstOrDefault();
            return ret;
        }
    }

    public void createNewFile(string username, string password, string fileName, string fileHash)
    {
        using (var db = new UserDBContext())
        {
            User ret = db.Users.Where(b => b.Username == username).Include(b => b.Files).FirstOrDefault();
            ret.CreateNewFile(username, password, fileName, fileHash);
            db.SaveChanges();
        }
    }
    public void deleteFile(string username, string password, string fileName)
    {
        using (var db = new UserDBContext())
        {
            User ret = db.Users.Where(b => b.Username == username).Include(b => b.Files).FirstOrDefault();
            UserFiles deletedfile = ret.deleteFile(username, password, fileName);
            db.UserFiles.Remove(deletedfile);
            db.SaveChanges();
        }
    }
}