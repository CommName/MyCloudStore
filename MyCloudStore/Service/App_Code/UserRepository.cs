using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserRepository
/// </summary>
public class UserRepository
{
    public UserRepository()
    {
        UserDBContext userDBContext = new UserDBContext();
        userDBContext.Users.ToList();
    }
}