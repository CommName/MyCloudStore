using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserContainer
/// </summary>
public class UserContainer
{


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
    }
}