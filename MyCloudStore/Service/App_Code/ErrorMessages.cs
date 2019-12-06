using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for ErrorMessages
/// </summary>
[DataContract]
public class ErrorMessages
{
    [DataMember]
    public string Message { get; set; }
    public ErrorMessages(string m)
    {
        this.Message = m;
        //
        // TODO: Add constructor logic here
        //
    }
}