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
    [FaultContract (typeof(ErrorMessages))]
    List<String> getYourFileNames(string username, byte[] password);

    [OperationContract]
    [FaultContract(typeof(ErrorMessages))]
    byte[] getFileHash(string username, byte[] password, string fileName);

    [OperationContract]
    [FaultContract(typeof(ErrorMessages))]
    uint getChunkSize();

    [OperationContract]
    [FaultContract(typeof(ErrorMessages))]
    void createNewFile(string username, byte[] password, string fileName, byte[] fileHash);

    [OperationContract]
    [FaultContract(typeof(ErrorMessages))]
    void deleteFile(string username, byte[] password, string fileName);

    [OperationContract]
    [FaultContract(typeof(ErrorMessages))]
    void uploadData(string username, byte[] password, string fileName, byte[] data);

    [OperationContract]
    [FaultContract(typeof(ErrorMessages))]
    bool downloadFile(string username, byte[] password, string fileName, out byte[] data, uint offset);

    [OperationContract]
    [FaultContract(typeof(ErrorMessages))]
    void RegisterUser(string username, byte[] password);

}
