using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICloudService" in both code and config file together.
[ServiceContract]
public interface ICloudService
{
    [OperationContract]
    List<String> getYourFileNames(string username, string password);
    
    [OperationContract]
    uint getChunkSize();

    [OperationContract]
    void createNewFile(string username, string password, string fileName, string fileHash);

    [OperationContract]
    void deleteFile(string username, string password, string fileName);

    [OperationContract]
    void uploadData(string username, string password, string fileName, byte[] data, int size);

    [OperationContract]
    bool downloadFile(string username, string password, string fileName, out byte[] data, uint offset);

    void RegisterUser(string username, string password);

}
