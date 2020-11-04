using ShoppingCart;
using System;
using System.Collections.Generic;

namespace OrderProcessing
{
    class OrderManager
    {
		List<Order> orders = new List<Order>();
        public List<Order> Orders 
        {
            get { return orders; }
            set { orders = value; }
        }
		public void Insert(Order order)
        {
            orders.Add(order);
        }
		public void Update(Order order)
        {
            foreach(Order ord in this.orders)
            {
                if (ord.OrderID == order.OrderID)
                    orders.Add(order);
            }        
        }
		public void Delete(Order order)
        {
            orders.Remove(order);
        }
		public List<Order> GetAll()
        {
            return orders;
        }
        public Order GetOrderByID(int orderId)
        {
           foreach(Order order in this.orders)
            {
                if (order.OrderID == orderId)
                    return order;
            }
            return null;
        }
        public List<Order>GetByCustomerID(string custid)
        {
           List<Order> orders = new List<Order>();
           foreach (Order order in this.orders)
            {
                if (order.theCustomer.UserID == custid)
                    return orders;
            }
            return null;
        }
    }
}
