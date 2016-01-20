using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3T5
{
    class Opiskelija
    {
        public string Nimi;
        public int OpNum;
        public string Osoite;

        public void PrintData()
        {
            Console.WriteLine("Nimi: " + Nimi);
            Console.WriteLine("Opiskelijanumero: " + OpNum);
            Console.WriteLine("Osoite: " + Osoite);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija[] opiskelijat = new Opiskelija[5];
            opiskelijat[0] = new Opiskelija { Nimi = "Matti", OpNum = 1234, Osoite = "Katu 1" };
            opiskelijat[1] = new Opiskelija { Nimi = "Antti", OpNum = 2222, Osoite = "Katu 31" };
            opiskelijat[2] = new Opiskelija { Nimi = "Aku", OpNum = 7777, Osoite = "Kuja 5467" };
            opiskelijat[3] = new Opiskelija { Nimi = "Saten", OpNum = 666, Osoite = "Tie 666" };
            opiskelijat[4] = new Opiskelija { Nimi = "asd", OpNum = 1, Osoite = "qwerty 123" };

            foreach(Opiskelija op in opiskelijat)
            {
                Console.WriteLine("-------------------------------------------");
                op.PrintData();
                Console.WriteLine("-------------------------------------------");
            }

            Console.ReadLine();


        }
    }
}
