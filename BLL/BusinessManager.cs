using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Catalog;

using DAL;
namespace BLL
{
    public static class BusinessManager
    {


        public static  Product GetProduct(int id)
        {
            return CatalogDBManger.GetProductByID(id);
 
        }
            public static IEnumerable<Product> GetAllProducts()
     { 
          
            //numerable<Product> allProducts = CatalogDBManger.GetAllProducts();

            IEnumerable<Product> allProducts = CatalogDBManger.GetAllProductsUsingDisconnected();
            return allProducts;

            #region  hardcoded way

            /* List<Product> allProducts = new List<Product>();
               allProducts.Add(new Product { ID = 1, Title = "Gerbera", Description = "Wedding Flower", UnitPrice = 6, Quantity = 5000 });
               allProducts.Add(new Product { ID = 2, Title = "Rose", Description = "Valentine Flower", UnitPrice = 15, Quantity = 7000 });
               allProducts.Add(new Product { ID = 3, Title = "Lotus", Description = "Worship Flower", UnitPrice = 26, Quantity = 0 });
               allProducts.Add(new Product { ID = 4, Title = "Carnation", Description = "Pink carnations signify a mother's love, red is for admiration and white for good luck", UnitPrice = 16, Quantity = 27000 });
               allProducts.Add(new Product { ID = 5, Title = "Lily", Description = "Lilies are among the most popular flowers in the U.S.", UnitPrice = 6, Quantity = 1000 });
               allProducts.Add(new Product { ID = 6, Title = "Jasmine", Description = "Jasmine is a genus of shrubs and vines in the olive family", UnitPrice = 26, Quantity = 0 });
               allProducts.Add(new Product { ID = 7, Title = "Daisy", Description = "Give a gift of these cheerful flowers as a symbol of your loyalty and pure intentions.", UnitPrice = 36, Quantity = 159 });
               allProducts.Add(new Product { ID = 8, Title = "Aster", Description = "Asters are the September birth flower and the the 20th wedding anniversary flower.", UnitPrice = 16, Quantity = 67 });
               allProducts.Add(new Product { ID = 9, Title = "Daffodil", Description = "Wedding Flower", UnitPrice = 6, Quantity = 5000 });
               allProducts.Add(new Product { ID = 10, Title = "Dahlia", Description = "Dahlias are a popular and glamorous summer flower.", UnitPrice = 7,  Quantity = 0 });
               allProducts.Add(new Product { ID = 11, Title = "Hydrangea", Description = "Hydrangea is the fourth wedding anniversary flower", UnitPrice = 12, Quantity = 0 });
               allProducts.Add(new Product { ID = 12, Title = "Orchid", Description = "Orchids are exotic and beautiful, making a perfect bouquet for anyone in your life.", UnitPrice = 10, Quantity = 700 });
               allProducts.Add(new Product { ID = 13, Title = "Statice", Description = "Surprise them with this fresh, fabulous array of Statice flowers", UnitPrice = 16, Quantity = 1500 });
               allProducts.Add(new Product { ID = 14, Title = "Sunflower", Description = "Sunflowers express your pure love.", UnitPrice = 8, Quantity = 2300 });
               allProducts.Add(new Product { ID = 15, Title = "Tulip", Description = "Tulips are the quintessential spring flower and available from January to June.", UnitPrice = 17 , Quantity = 10000 });
            */

            #endregion
     }



        public static IEnumerable<Product> GetSoldOutProducts(){

           IEnumerable<Product> products = GetAllProducts();
            return products;
            //apply filter
            // apply some business query
            //LINQ: Language Intergrated Query
            // var soldOutProducts = from product in products select product;
            /*  var soldOutProducts = from product in products
                                    where product.Quantity ==0
                                    select product;

              return soldOutProducts ;
            */


        }


        public static bool UpdateProduct(Product theProduct)
        {
            return CatalogDBManger.Update(theProduct);
        }
        public static  bool DeleteProduct(int id)
        {
            return CatalogDBManger.Delete(id);
        }


    }
}
