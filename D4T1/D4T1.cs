using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4T1
{
    class Hissi
    { 
    private int floor;
    public int Floor
    {
        get
        {
            return floor;
        }

        set
        {
                if (value < 1)
                    Console.WriteLine("too low");
                else if (value > 5)
                    Console.WriteLine("too high");
                else
                { 
                    Console.WriteLine("current floor: "+value);
                    floor = value;
                }
            }

        }
    }
    class D4T1
    {
        static void Main(string[] args)
        {
            string line;
            int number;
            while (true)
            {
                Hissi hissi = new Hissi();
                Console.Write("floor number > ");
                line = Console.ReadLine();
                bool result = int.TryParse(line, out number);
                // number (integer) was given correctly, use it..
                if (result)
                {
                    hissi.Floor = number;
                }
                else
                    Console.WriteLine("Not a Number");
            }

        }
    }
}
