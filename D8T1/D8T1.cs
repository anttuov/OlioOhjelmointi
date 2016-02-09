using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D8T1
{
    class D8T1
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("Dice, one test throw value is " + r.Next(1, 6));


            string text;
            int inum;
            double yht = 0;
            int noppa;
            int[] numerot = new int[6];
            Array.Clear(numerot, 0, 6);


            Console.Write(" How many times you want to throw a dice :  ");
            text = Console.ReadLine();
            if (int.TryParse(text, out inum))
            {
                for(int i = 0; i< inum; i++)
                {
                    noppa = r.Next(0, 6);
                    numerot[noppa]++;
                    yht = yht + noppa+1;
                }
                Console.WriteLine("keskiarvo: " + yht / inum);
                for(int i=0; i<6; i++)
                {
                    Console.WriteLine(i+1 + " count is " + numerot[i]);
                }
            }
        }
    }
}
