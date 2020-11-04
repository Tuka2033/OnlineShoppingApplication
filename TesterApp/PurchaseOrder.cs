using System;
using System.Collections.Generic;

using CRM;
using ShoppingCart;

namespace OrderProcessing
{
    class PurchaseOrder:Order
    {

        
            public Customer theCustomer { get; set; }
            public List<Item> Items = new List<Item>();

            public PurchaseOrder() { }
            public PurchaseOrder(int orderId, DateTime orderDate, Customer theCustomer, List<Item> items)
            {
                this.OrderID = orderId;
                this.OrderDate = orderDate;
                this.theCustomer = theCustomer;
                Items = items;
            }
            public override string ToString()
            {
                return "Order Details\n" + "Order ID: " + OrderID + "\n" + "Order Date: " + OrderDate + "\n" + "\nCustomer Details\n" + theCustomer;
            }
        }
    }

