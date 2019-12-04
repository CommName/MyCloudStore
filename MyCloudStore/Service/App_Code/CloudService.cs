using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CloudService" in code, svc and config file together.
public class CloudService : ICloudService
{
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
        throw new NotImplementedException();
    }

    public List<string> getYourFileNames(string username, string password)
    {
        List<string> ret = new List<string>();
        ret.Add("asdlkfa");
        return ret;
    }

    public void uploadData(string username, string password, string fileName, byte[] data, int size)
    {
        throw new NotImplementedException();
    }
}
