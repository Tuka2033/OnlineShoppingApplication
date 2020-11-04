using Catalog;

using CRM;
using ShoppingCart;
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;

namespace OrderProcessing
{
    class OrderTest
    {
        public static void Main(string[]args)
        {
            DateTime ordDate = DateTime.Now;
            Customer customer1 = new Customer
            {
                UserID = "100",
                FullName = "Arun Surase",
                Email = "arun@gmail.com",
                ContactNubmer = "9689607171",
                Location = "Pune",
                Password = "seed"
            };

            Product product1 = new Product(1, "Rose", "Valentine flower", 10, 400);
            Product product2 = new Product(2, "Marigold", "Festival flower", 5, 500);
            
            Item item1 = new Item(product1,34);
            Item item2 = new Item(product2,56);
            
            Cart cart1 = new Cart();

            cart1.AddToCart(item1);
            cart1.AddToCart(item2);

            List<Item> cartItems = cart1.Items;
            Order theOrder = new Order(1001, ordDate, customer1, cartItems);


            IOrderService service = new PurchaseOrderService();
            service.Create(theOrder);


          List<Order> allOrders = service.GetOrders();
          foreach(Order order in allOrders)
            {

                Console.WriteLine(order.theCustomer.FullName);
                Console.WriteLine(order.OrderDate);
                Console.WriteLine(order.OrderID);
                Console.WriteLine(" Item Details....");
                foreach (Item item in theOrder.Items)
                {
                    Console.WriteLine(item.theProduct + "Quantity=" + item.Quantity);
                }

            }
            
            Console.ReadLine();
        }
    }
}
