using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KinproService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EntreeService" in both code and config file together.
    public class EntreeService : IEntreeService
    {
        KinproPressingEntities _KinproPressingEntitie;
        public EntreeService()
        {
            _KinproPressingEntitie = new KinproPressingEntities();
        
        }
        public List<GetAllClientOrders_Result> GetAllClientOrders()
        {
            ObjectResult<GetAllClientOrders_Result> order = _KinproPressingEntitie.GetAllClientOrders();
            return order.ToList();
        }

        public GetClientOrderByOrderNumber_Result GetClientOrderByOrderNumber(int orderNumber)
        {
            ObjectResult<GetClientOrderByOrderNumber_Result> order = _KinproPressingEntitie.GetClientOrderByOrderNumber(orderNumber);
            return order.FirstOrDefault();
        }

        public List<GetClientOrdersByPhoneNumber_Result> GetClientOrdersByPhoneNumber(int phoneNumber)
        {
            ObjectResult<GetClientOrdersByPhoneNumber_Result> order = _KinproPressingEntitie.GetClientOrdersByPhoneNumber(phoneNumber);
            return order.ToList();
        }

        public List<GetClientItermsOrder_Result> GetClientItermsOrder(int orderNumber)
        {
            ObjectResult<GetClientItermsOrder_Result> order = _KinproPressingEntitie.GetClientItermsOrder(orderNumber);
            return order.ToList();
        }

        public List<GetClientOrderItemsByRay_Result> GetClientOrderItemsByRay(int ray, int orderNumber)
        {
            ObjectResult<GetClientOrderItemsByRay_Result> order = _KinproPressingEntitie.GetClientOrderItemsByRay(ray, orderNumber);
            return order.ToList();
        }


        public void AddNewItems(int itemId, int orderNumber, int ray, string color, int itemStatus, int clientId)
        {
            _KinproPressingEntitie.AddNewItems(itemId, orderNumber, ray, color, itemStatus, clientId);
        }

        public void UpdateClientOrder(int orderStatus, int orderNumber, int employeeId, int total)
        {
            _KinproPressingEntitie.UpdateClientOrder(orderStatus, orderNumber, employeeId, total);
        }

        public void UpdateClientOrderItems(int itemId, int ray, string color, int itemStatus, int employeeId)
        {
            _KinproPressingEntitie.UpdateClientOrderItems(itemId, ray, color, itemStatus, employeeId);
        }

        public void DeleteOrder(int id)
        {
            _KinproPressingEntitie.DeleteOrder(id);
        }

        public void DeleteOrderItem(int itemId)
        {
            _KinproPressingEntitie.DeleteOrderItem(itemId);
        }


        public int AddNewOrder(int clientId, int total, int orderStatus, int orderNumber, int employeeId)
        {
            ObjectResult<decimal?> orderId =  _KinproPressingEntitie.AddNewOrder(clientId, total, orderStatus, orderNumber, employeeId);
            return Convert.ToInt32(orderId.SingleOrDefault());
        }
    }

}
