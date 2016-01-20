using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3T6
{
    class GPU
    {

        public class Memory
        {
            private int MC;
            private int MS;

            public void PrintData()
            {
                Console.WriteLine("    Memory Clock (MHZ): " + MC);
                Console.WriteLine("    Muistin määrä (GB): " + MS);
            }

            public Memory(int _MC, int _Memory)
            {

                MC = _MC;
                MS = _Memory;
            }

        }

        public void PrintData()
        {
            Console.WriteLine("Nimi: " + Name);
            Console.WriteLine("Valmistaja: " + Valmistaja);
            Console.WriteLine("Core Clock (MHZ): " + CC);
            Console.WriteLine("Muisti: ");
            Mem.PrintData();
        }



        public GPU(string _Name, string _Valmistaja, int _CC, int _MC, int _Memory)
        {
            Name = _Name;
            Valmistaja = _Valmistaja;
            CC = _CC;
            Mem = new Memory(_MC, _Memory);
        }

        private string Name;
        private string Valmistaja;
        private int CC;
        private Memory Mem;



    }
    class Program
    {
        static void Main(string[] args)
        {
            GPU[] gpus = new GPU[3];
            gpus[0] = new GPU("Titan X", "Nvidia", 1000, 7000, 12);
            gpus[1] = new GPU("GTX 750 Ti", "Nvidia", 1020, 5400, 2);
            gpus[2] = new GPU("R9 390", "AMD", 1060, 6100, 8);



            foreach (GPU gpu in gpus)
            {
                Console.WriteLine("-------------------------------------------");
                gpu.PrintData();
                Console.WriteLine("-------------------------------------------");
            }

            Console.ReadLine();


        }
    }
}