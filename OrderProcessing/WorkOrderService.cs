﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class WorkOrderService: IOrderService
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


            //logic for creating work order

                Console.WriteLine("Order is created....");
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
                List<Order> orders = new List<Order>();
                //Get all workOrders orders 
                orders=mgr.Orders;

                return orders;

            }

            public bool Process(Order theOrder)
            {
                bool status = false;
            // Business Logic for processing WorkOrder

            Console.WriteLine("Work Order is processed");

                return status;

            }

            public bool Update(Order order)
            {
                bool status = false;
            // CRUD Operations update
            Console.WriteLine(" Existing order details are updated..");
                return status;
            }
        }
}

