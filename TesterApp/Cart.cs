using System.Collections.Generic;
namespace ShoppingCart
{
    public class Cart
    {
       private  List<Item> items = new List<Item>();  //generic list collection of Items
       public List<Item> Items
       {
            get { return items; }
            set { items = value; }
       }

        public void AddToCart(Item item)
        {
            items.Add(item);
        }

        public void RemoveFromCart(Item item)
        {
            items.Remove(item);
        }
    }
}