using System;

namespace Catalog
{

    [Serializable]
   public class Product
    {
        private string title;
        private string description;
        private int quantity;
        private float unitPrice;
        private int id;

        //readonly property
        public int ID
        {
            set { this.id = value; }
            get { return this.id; }
        }
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }
        public float UnitPrice
        {
            get { return this.unitPrice; }
            set { this.unitPrice = value; }
        }

        public Product() { }
        public Product(int id, string title, string description, int quantity, float unitPrice)
        {
            this.id = id;
            this.Title = title;
            this.Description = description;
            this.UnitPrice = unitPrice;
            this.quantity = quantity;
        }
        ~Product()
        {
           // to DeInitialize object instance before getting destroyed.
        }

        //Object
        //object

        public override string ToString()
        {
            //return base.ToString();

            return this.ID + " " + this.Title + " " + this.Description + " " + this.UnitPrice + " " + this.Quantity;
        }
    }
}
