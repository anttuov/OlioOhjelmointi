using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4T5
{
    class D4T5
    {
        class Radio
        {
            public bool Power;
            private int volume;
            public int Volume
            {
                get
                {
                    return volume;
                }

                set
                {
                    if (value >= 0 && value <= 9)
                        volume = value;
                    else
                        Console.WriteLine("voimakkuuden arvo pitää olla 0-9");
                }

            }
        private double freq;
        public double Freq
            {
                get
                {
                    return freq;
                }

                set
                {
                    if (value >= 2000 && value <= 26000)
                        freq = value;
                    else
                        Console.WriteLine("taajuuden pitää olla 2000-26000");
                }

            }

            public Radio(bool p, int v, double f)
            {
                Power = p;
                Volume = v;
                Freq = f;
            }

            public void PrintData()
            {
                Console.WriteLine("power: " + Power + " voimakkuus: " + volume + " taajuus: " + freq);
            }
        }
        static void Main(string[] args)
        {
            Radio radio = new Radio(false, 5, 5000.0);
            radio.Power = true;
            radio.Freq = 25999;
            radio.Freq = 1000;
            radio.Volume = 20;

            radio.PrintData();
        }
    }
}
