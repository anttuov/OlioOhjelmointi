using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4T2
{
    class Amp
    {
        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }

            set
            {
                if (value < 0)
                { 
                    Console.WriteLine("volume set to min 0");
                    volume = 0;
                }
                else if (value > 100)
                {
                    Console.WriteLine("volume set to max 100");
                    volume = 100;
                }
                else
                {
                    Console.WriteLine("new volume: " + value);
                    volume = value;
                }
            }

        }
    }
    class D4T2
    {
        static void Main(string[] args)
        {
            Amp amp = new Amp();
            string line;
            int number;
            while (true)
            {
                Console.WriteLine("current volume: " + amp.Volume);
                Console.Write("set new volume > ");
                line = Console.ReadLine();
                bool result = int.TryParse(line, out number);
                // number (integer) was given correctly, use it..
                if (result)
                {
                    amp.Volume = number;
                }
                else
                    Console.WriteLine("Not a Number");
            }
        }
    }
}
