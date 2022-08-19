using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEg
{
    internal class Product
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public float Price { get; set; }

        public Product() { }

        public Product(int pid, string pname, float price)
        {
            Pid = pid;
            Pname = pname;
            Price = price;
        }

        public static List<Product> products = new List<Product>();

        public static List<Product> getAllProds()
        {
            products.Add(new Product(1, "Pen", 34));
            products.Add(new Product(2, "Eraser", 29));
            products.Add(new Product(3, "Pencil", 90));
            return products;
        }

        public static Product getProdById(int id)
        {
            Product? p = (from i in products
                         where i.Pid == id
                         select i).SingleOrDefault();

            Product? p1 = products.Where(x => x.Pid == id).Select(x => x).SingleOrDefault();

            return p;
        }

        public override string ToString()
        {
            return "Pid: "+Pid+" Pname: "+Pname+" price: "+Price;
        }
    }
}
