﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CloudService" in code, svc and config file together.
public class CloudService : ICloudService
{
    public static uint chunkSize = 2; //U mb
    public void createNewFile(string username, string password, string fileName, string fileHash)
    {
        throw new NotImplementedException();
    }

    public void deleteFile(string username, string password, string fileName)
    {
        throw new NotImplementedException();
    }

    public bool downloadFile(string username, string password, string fileName, out byte[] data, uint offset)
    {
        throw new NotImplementedException();
    }

    public uint getChunkSize()
    {
        return chunkSize;
    }

    public List<string> getYourFileNames(string username, string password)
    {
        List<string> ret = new List<string>();
        //ret.Add("asdlkfa");
        User novi = new User();
        novi.id = 5;
        novi.Username = password;
        novi.Password = username;
        UserDBContext db = new UserDBContext();
        db.Users.Add(novi);
        db.SaveChanges();
        ret.Add(db.Users.ToList().First().Password);
        return ret;
    }

    public void RegisterUser(string username, string password)
    {
        UserContainer.Instance.registerUser(username, password);
    }

    public void uploadData(string username, string password, string fileName, byte[] data, int size)
    {
        throw new NotImplementedException();
    }
}
