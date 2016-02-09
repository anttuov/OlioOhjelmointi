using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D8T2
{
    class Product
    {
        public string nimi;
        public double hinta;
    }
    class D8T2
    {
        static void Main(string[] args)
        {
            List<Product> ostoskarry = new List<Product>();
            Product beer = new Product { nimi = "beer", hinta = 1.05 };
            Product cheese = new Product { nimi = "cheese", hinta = 5 };
            Product milk = new Product { nimi = "milk", hinta = 0.95 };

            ostoskarry.Add(beer);
            ostoskarry.Add(cheese);
            ostoskarry.Add(milk);

            foreach(Product p in ostoskarry)
            {
                Console.WriteLine("nimi: " + p.nimi + " hinta: " + p.hinta);
            }

        }
    }
}
