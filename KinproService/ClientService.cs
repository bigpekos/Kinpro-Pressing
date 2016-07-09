using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KinproService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ClientService" in both code and config file together.
    public class ClientService : IClientService
    {
        KinproPressingEntities _KinproPressingEntitie;
        public ClientService()
        {
            _KinproPressingEntitie = new KinproPressingEntities();      
        }

        public List<GetAllClients_Result> GetAllClient()
        {
            ObjectResult<GetAllClients_Result> client = _KinproPressingEntitie.GetAllClients();
            return client.ToList();
        }

        public GetClientByName_Result GetClientByName(string clientName)
        {
          ObjectResult<GetClientByName_Result> client = _KinproPressingEntitie.GetClientByName(clientName);
          return client.FirstOrDefault();
        }


        public int AddClient(string name, string firstName, int phone )
        {
            return _KinproPressingEntitie.AddClient(name, firstName, phone);
        }

        public void DeleteClient(int clientId)
        {
            _KinproPressingEntitie.DeleteClient(clientId);
        }

        public void UpdateClient(string name, string firstName, int employeeId, int phone, string clientAddress, int clientId)
        {
            _KinproPressingEntitie.UpdateClient(name, firstName, employeeId, phone, clientAddress, clientId);
        }


        public GetClientByPhoneNumber_Result GetClientByPhoneNumber(int phoneNumber)
        {
            ObjectResult<GetClientByPhoneNumber_Result> client = _KinproPressingEntitie.GetClientByPhoneNumber(phoneNumber);
            return client.FirstOrDefault();
        }
    }
}
