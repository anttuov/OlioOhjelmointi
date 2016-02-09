using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D8T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("Dice, one test throw value is " + r.Next(1, 6));
        }
    }
}
