using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KinproService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEntreeService" in both code and config file together.
    [ServiceContract]
    public interface IEntreeService
    {
        [OperationContract]
        List<GetAllClientOrders_Result> GetAllClientOrders();

        [OperationContract]
        GetClientOrderByOrderNumber_Result GetClientOrderByOrderNumber(int orderNumber);

        [OperationContract]
        List<GetClientOrdersByPhoneNumber_Result> GetClientOrdersByPhoneNumber(int phoneNumber);

        [OperationContract]
        List<GetClientItermsOrder_Result> GetClientItermsOrder(int orderNumber);

        [OperationContract]
        List<GetClientOrderItemsByRay_Result> GetClientOrderItemsByRay(int ray, int orderNumber);

        [OperationContract]
        int AddNewOrder(int clientId, int total, int orderStatus, int orderNumber, int employeeId);

        [OperationContract]
        void AddNewItems(int itemId, int orderNumber, int ray, string color, int itemStatus, int clientId);

        [OperationContract]
        void UpdateClientOrder(int orderStatus, int orderNumber, int employeeId, int total);

        [OperationContract]
        void UpdateClientOrderItems(int itemId, int ray, string color, int itemStatus, int employeeId);

        [OperationContract]
        void DeleteOrder(int id);

        [OperationContract]
        void DeleteOrderItem(int itemId);
    }
}
