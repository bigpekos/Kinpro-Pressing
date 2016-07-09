using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KinproService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IClientService" in both code and config file together.
    [ServiceContract]
    public interface IClientService
    {
        [OperationContract]
        List<GetAllClients_Result> GetAllClient();

        [OperationContract]
        GetClientByName_Result GetClientByName(string clientName);

        [OperationContract]
        int AddClient(string name, string firstName, int phone);

        [OperationContract]
        void DeleteClient(int clientId);

        [OperationContract]
        void UpdateClient(string name, string firstName, int employeeId, int phone, string clientAddress, int clientId);

        [OperationContract]
        GetClientByPhoneNumber_Result GetClientByPhoneNumber(int phoneNumber); 
    }
}
