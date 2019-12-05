using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
/// <summary>
/// Summary description for UserDBContext
/// </summary>
public class UserDBContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<UserFiles> UserFiles { get; set; }
}