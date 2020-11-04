using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    class WorkOrderService: IOrderService
        {
        private DeliverManager mgr = new DeliverManager();
            public WorkOrderService()
            {
            }

            public bool Cancel(Order order)
            {
                bool status = false;
                //cancellation logic for WorkOrder assigned
                return status;
            }

            public void Create(Order order)
            {
                mgr.Insert(order);
            }

            public Order GetOrder(int orderId)
            {
                Order theOrder = new Order();
                // get the work order based on id  sent

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
                // Business Logic for processing WorkOrder

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

