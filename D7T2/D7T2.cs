using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D7T2
{
    class D7T2
    {
        static void Main(string[] args)
        {
            string text;
            int inum;
            double dnum;
            List<int> ints = new List<int>();
            List<double> doubles = new List<double>(); 

            while(true)
            {
                Console.Write("Give a number (enter or not a number ends) : ");
                text = Console.ReadLine();
                if (int.TryParse(text, out inum))
                {
                    Console.WriteLine("int: "+inum);
                    ints.Add(inum);
                }
                else if (double.TryParse(text, out dnum))
                {
                    Console.WriteLine("double: "+dnum);
                    doubles.Add(dnum);
                }
                else
                {
                    Console.WriteLine("ei int eikä double");
                    break;
                }
                
            }
            //int tiedosto
            System.IO.StreamWriter outputFile = new System.IO.StreamWriter("ints.txt");
            foreach (int i in ints)
            { 
            outputFile.WriteLine(i);
            }
            outputFile.Close();

            //double tiedosto
            outputFile = new System.IO.StreamWriter("doubles.txt");
            foreach (double d in doubles)
            {
                outputFile.WriteLine(d);
            }
            outputFile.Close();
        }
    }
}
