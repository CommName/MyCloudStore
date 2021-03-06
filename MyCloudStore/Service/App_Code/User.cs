﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.ServiceModel;

/// <summary>
/// Summary description for User
/// </summary>
public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public byte[] Password { get; set; }
    public ICollection<UserFiles> Files { get; set; }

    public void CreateNewFile(string username, byte[] password, string fileName, byte[] fileHash)
    {
        if (username != this.Username || !this.Password.SequenceEqual(password))
        {
            throw new FaultException<ErrorMessages>(new ErrorMessages("Wrong username or password!"));
        }
        //Proverava da li fajl vec postoji
        foreach (UserFiles file in Files)
        {
            if(file.fileName == fileName)
            {
                throw new FaultException<ErrorMessages>(new ErrorMessages("File with the same name already exists"));
            }
        }
        UserFiles noviFajl = new UserFiles();
        noviFajl.fileName = fileName;
        noviFajl.hash = fileHash;
        this.Files.Add(noviFajl);
        string path = System.IO.Path.Combine(UserContainer.Putanja, username);

        using (FileStream stream = new FileStream(System.IO.Path.Combine(path,fileName), FileMode.Create))
        {

        }

    }

    public byte[] getFileHash(string username, byte[] password, string fileName)
    {
        if (username != this.Username || !this.Password.SequenceEqual(password))
        {
            throw new FaultException<ErrorMessages>(new ErrorMessages("Wrong username or password!"));
        }
        //Provera da li fajl postoji

        foreach (UserFiles file in Files)
        {
            if (file.fileName == fileName)
            {
                return file.hash;
            }
        }
        throw new FaultException<ErrorMessages>(new ErrorMessages("File not found!"));
    }

    public UserFiles deleteFile(string username, byte[] password, string fileName)
    {
        if (username != this.Username || !this.Password.SequenceEqual(password))
        {
            throw new FaultException<ErrorMessages>(new ErrorMessages("Wrong username or password!"));
        }
        //Provera da li fajl postoji

        foreach (UserFiles file in Files)
        {
            if (file.fileName == fileName)
            {
                string path = System.IO.Path.Combine(UserContainer.Putanja, username);
                //brisanje fjala
                File.Delete(System.IO.Path.Combine(path, fileName));

                return file;
            }
        }
        throw new FaultException<ErrorMessages>(new ErrorMessages("File not found!"));

    }

    public bool getFileBytes(string username, byte[] password, string fileName, out byte[] data, uint offset, int chunkSize)
    {
        if (username != this.Username || !this.Password.SequenceEqual(password))
        {
            throw new FaultException<ErrorMessages>(new ErrorMessages("Wrong username or password!"));
        }

        foreach (UserFiles file in Files)
        {
            if(file.fileName == fileName)
            {
                string path = System.IO.Path.Combine(UserContainer.Putanja, username);
                using (FileStream stream = new FileStream(System.IO.Path.Combine(path, fileName), FileMode.Open))
                {
                    if (stream.Length < offset)
                    {
                        throw new FaultException<ErrorMessages>(new ErrorMessages("File not big enough"));

                    }
                    stream.Seek(offset*1024,SeekOrigin.Begin);
                    using (var sw = new BinaryReader(stream))
                    {
                        data = sw.ReadBytes(chunkSize*1024);
                        if(sw.BaseStream.Position == sw.BaseStream.Length)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }
        throw new FaultException<ErrorMessages>(new ErrorMessages("File not found"));

    }

    public void appendData(string username, byte[] password, string fileName, byte[] data)
    {
        if (username != this.Username || !this.Password.SequenceEqual(password))
        {
            throw new FaultException<ErrorMessages>(new ErrorMessages("Wrong username or password!"));
        }

        foreach (UserFiles file in Files)
        {
            if (file.fileName == fileName)
            {
                string path = System.IO.Path.Combine(UserContainer.Putanja, username);

                using (FileStream stream = new FileStream(System.IO.Path.Combine(path, fileName), FileMode.Append))
                {
                    
                    using (var sw = new BinaryWriter(stream))
                    {
                        sw.Write(data);
                    }
                }
                return;
            }
        }
        throw new FaultException<ErrorMessages>(new ErrorMessages("File not found!"));

    }

    public List<string> getFileNames(string username, byte[] password)
    {
        if (username != this.Username || !this.Password.SequenceEqual(password))
        {
            throw new FaultException<ErrorMessages>(new ErrorMessages("Wrong username or password!"));
        }
        List<string> ret = new List<string>();
        foreach(UserFiles file in Files)
        {
            ret.Add(file.fileName);
        }
        return ret;
    }

}