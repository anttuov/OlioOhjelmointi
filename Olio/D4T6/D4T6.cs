using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4T6
{
    class Paaclass
    {
        public string nimi;
        public int vuosi;
        public override string ToString()
        {
            return(nimi+", "+vuosi);
        }
    }

    class CD : Paaclass
    {
        public string artisti;
        public void PrintData()
        {
            Console.WriteLine("CD: " + base.ToString() + ", " + artisti);
        }
    }
    class DVD : Paaclass
    {
        public string ohjaaja;
        public float pituus;
        public virtual void PrintData()
        {
            Console.WriteLine("DVD: "+base.ToString()+ ", " + ohjaaja + ", "+pituus+"h");
        }
    }

    class Bluray : DVD
    {
        public override void PrintData()
        {
            Console.WriteLine("Bluray: " + base.ToString() + ", " + ohjaaja + ", " + pituus + "h");
        }
    }
    class D4T6
    {
        static void Main(string[] args)
        {
            CD cd1 = new CD();
            cd1.nimi = "greatest hits";
            cd1.artisti = "queen";
            cd1.vuosi = 1981;
            cd1.PrintData();

            DVD dvd1 = new DVD();
            dvd1.nimi = "pulp fiction";
            dvd1.ohjaaja = "tarantino";
            dvd1.pituus = 2.9f;
            dvd1.vuosi = 1994;
            dvd1.PrintData();

            Bluray bd1 = new Bluray();
            bd1.nimi = "mad max fury road";
            bd1.ohjaaja = "miller";
            bd1.pituus = 2.0f;
            bd1.vuosi = 2015;
            bd1.PrintData();

        }
    }
}
