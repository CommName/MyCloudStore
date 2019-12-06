using System;
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
        UserContainer.Instance.createNewFile(username, password, fileName, fileHash);
    }

    public void deleteFile(string username, string password, string fileName)
    {
        UserContainer.Instance.deleteFile(username, password, fileName);
    }

    public bool downloadFile(string username, string password, string fileName, out byte[] data, uint offset)
    {
        return UserContainer.Instance.getUser(username).getFileBytes(username, password, fileName, out data, offset*chunkSize,(int)chunkSize);
    }

    public uint getChunkSize()
    {
        return chunkSize;
    }

    public List<string> getYourFileNames(string username, string password)
    {
        User user = UserContainer.Instance.getUser(username);
        if (user == null)
        {
            throw new FaultException<ErrorMessages>(new ErrorMessages("No users found"));
        }
        return user.getFileNames(username, password);
    }

    public void RegisterUser(string username, string password)
    {
        UserContainer.Instance.registerUser(username, password);
    }

    public void uploadData(string username, string password, string fileName, byte[] data, int size)
    {
        UserContainer.Instance.getUser(username).appendData(username, password, fileName, data, size);
    }
}
