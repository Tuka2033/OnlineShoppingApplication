using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class PurchaseOrderService : IOrderService
    {

        PurchaseManager mgr = PurchaseManager.GetManager();
        public PurchaseOrderService() 
        {
        }
        public bool Cancel(Order order)
        {
            bool status = false;

            return status;
        }

        public void Create(Order order)
        {
            //Create the Purchase Order with the help of OrderManager
         
            mgr.Insert(order);
            
        }

        public Order GetOrder(int orderId)
        {
            Order theOrder = new Order();
                // get the order based on id of order sent

            return theOrder;
        }

        public List<Order> GetOrders()
        {
            
            List<Order> orders = mgr.GetAll();
           
            return orders;
            
        }

        public bool Process(Order theOrder)
        {
            bool status = false;
            // Business Logic for processing Order

            return status;

        }

        public bool Update(Order order)
        {
            bool status = false;
            // CRUD Operations update
            return status;
        }
    }
}
