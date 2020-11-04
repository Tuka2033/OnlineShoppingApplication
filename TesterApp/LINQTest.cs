using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Catalog;
using BLL;
using System.Runtime.Remoting.Channels;

namespace TesterApp
{
    public class LINQTest
    {
        // will act like console UI

        static void Main(string[] args)
        {
        
           IEnumerable<Product> allProducts = BusinessManager.GetAllProducts();
          
            foreach (Product theProduct in allProducts)
            {
                Console.WriteLine(theProduct.Title + " " + theProduct.Quantity);
            }

              // Specify the data source.
            int[] scores = new int[] { 97, 92, 81, 60,65 };

            // Define the query expression.
            IEnumerable<int> result =    from score in scores
                                         where score > 80
                                         select score;
            foreach (int score in result)
            {
                Console.WriteLine(score);
            }


            List<int> numbers = new List<int>() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };



            // The query variable can also be implicitly typed by using var
            IEnumerable<int> filteringQuery = from num in numbers
                                              where num < 3 || num > 7
                                              select num;

            Console.WriteLine(" Show number which are not  in between 3 and 7");
            foreach (int score in filteringQuery)
            {
                Console.WriteLine(score);
            }

            // Query #2.
            IEnumerable<int> orderingQuery = from num in numbers
                                             where num < 3 || num > 7
                                             orderby num descending
                                             select num;
            Console.WriteLine(" Show number which are not  in between 3 and 7 in ascending manner");
            foreach (int score in orderingQuery)
            {
                Console.WriteLine(score);
            }


         /*  var allSoldOutPrdoucts = from product in allProducts
                                    where product.Quantity > 5000
                                    select product;*/


            IEnumerable<Product> allSoldOutProducts = BusinessManager.GetSoldOutProducts();
            Console.WriteLine(" Show only those product title which are sold out");


           
            foreach (Product  theProduct in allSoldOutProducts)
            {
                Console.WriteLine(theProduct.Title + " " + theProduct.Quantity);
            }

            Console.ReadLine();
        }
    }
}
