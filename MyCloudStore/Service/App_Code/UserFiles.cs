using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
/// <summary>
/// Summary description for UserFiles
/// </summary>
public class UserFiles
{
    public int Id { get; set; }
    public string fileName { get; set; }
    public byte[] hash { get; set; }

    public int UserID { get; set; }
    [ForeignKey("UserID")]
    public User User { get; set; }

}