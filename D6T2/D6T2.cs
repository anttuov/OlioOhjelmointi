using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6T2
{
    class CD
    {
        public string name;
        public string artist;
        public Dictionary<string, string> songs = new Dictionary<string, string>();

        public void PrintData()
        {
            Console.WriteLine("name:" + name);
            Console.WriteLine("artist:" + artist);
            Console.WriteLine("songs:");
            foreach (KeyValuePair<string, string> kvp in songs)
            {
                Console.WriteLine("{0} - {1}", kvp.Key, kvp.Value);
            }
        }

    }
    class D6T2
    {
        static void Main(string[] args)
        {
            CD cd1 = new CD();
            cd1.artist = "Nightwish";
            cd1.name = "Endless Forms Most Beautiful";
            cd1.songs.Add("Shudder Before the Beautiful", "6:29");
            cd1.songs.Add("Weak Fantasy", "5:23");
            cd1.songs.Add("Elan", "4:45");
            cd1.PrintData();

        }
    }
}
