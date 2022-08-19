using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEg
{
    internal class ProductClient
    {
        //client class
        public static List<Product> prds = Product.getAllProds();

        public static void DisplayProducts()
        {
            foreach(var item in prds)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Displayprdbyid()
        {
            Console.WriteLine("enter the product id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Product p = Product.getProdById(id);
            Console.WriteLine(p.ToString());
        }

        public static void Main(string[] args)
        {
            DisplayProducts();
            Displayprdbyid();
        }
    }
}
