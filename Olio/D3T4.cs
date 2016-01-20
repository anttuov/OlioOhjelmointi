using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3T4
{
    class Vehicle
    {
        public string Name;
        public int Speed;
        public int Tyres;

        public void PrintData()
        {
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Speed: " + Speed);
            Console.WriteLine("Tyres: " + Tyres);
        }

        public string Tostring()
        {
            return (Name + "|" + Speed + "|" + Tyres);
        }

        public Vehicle(string _Name, int _Speed, int _Tyres)
        {
            Name = _Name;
            Speed = _Speed;
            Tyres = _Tyres;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle("Auto", 200, 4);
            v.Speed = 50;
            v.Tyres = 2;
            v.Name = "Mopo";
            v.PrintData();
            Console.WriteLine( v.Tostring() );
            Console.ReadLine();


        }
    }
}
