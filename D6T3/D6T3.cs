using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6T3
{
    class D6T3
    {
        static void Main(string[] args)
        {
            List<string> kortit = new List<string>();
            string[] Maat = { "Hertta", "Ruutu", "Risti", "Pata" };
            for(int i=0; i<4; i++)
            {
                for(int ii=1; ii<=13; ii++)
                {
                    kortit.Add(Maat[i] + ii);
                }
            }

            
            int a = 0;
            foreach(string s in kortit)
            {
                a++;
                Console.Write(s +", ");
                if (a % 13 == 0)
                    Console.Write("\n");
            }
            Console.WriteLine("yht " + kortit.Count() + " korttia.");

            //sekoitus
            var r = new Random();
            kortit.Sort((x,y) => r.Next(-10,10));

            foreach (string s in kortit)
            {
                a++;
                Console.Write(s + ", ");
                if (a % 13 == 0)
                    Console.Write("\n");

            }

        }
    }
}
