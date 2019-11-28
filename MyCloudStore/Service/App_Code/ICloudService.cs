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

    //Upload file functions
    [OperationContract]
    void createNewFile(string username, string password, string fileName, string fileHash);

    [OperationContract]
    void uploadData(string username, string password, byte[] data, int size);

    [OperationContract]
    void saveFile(string username, string password);

    [OperationContract]
    void discardFile(string username, string password);

    void discardSavedFile(string username, string password, string fileName);

    //Download file functions
    [OperationContract]
    void downloadFile(string username, string password, string fileName);

    [OperationContract]
    byte[] getData(string username, string password, out bool done, int size);

}
