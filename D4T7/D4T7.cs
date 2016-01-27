using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4T7
{
    class Koira
    {
        public string nimi;
        public int ika;
        public virtual void PrintData()
        {
            Console.WriteLine(nimi + " " + ika);
        }
    }

    class Rotu : Koira
    {
        public string rotu;
        private readonly int reknumero;
        public Rotu(int rek)
        {
            reknumero = rek;
        }
        public override void PrintData()
        {
            Console.WriteLine(nimi + " " + ika + " " + rotu + " " + reknumero);
        }

    }
    class D4T7
    {
        static void Main(string[] args)
        {
            Koira musti = new Koira();
            musti.nimi = "Musti";
            musti.ika = 5;
            musti.PrintData();
            Rotu fifi = new Rotu(58547217);
            fifi.nimi = "Fifi";
            fifi.ika = 1;
            fifi.rotu = "Chihuahua";
            fifi.PrintData();



        }
    }
}
