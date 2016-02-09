using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace D7T3
{
    [Serializable]
    class Ohjelma
    {
        public string nimi;
        public string kanava;
        public double alkuaika;
        public double loppuaika;
        public string info;
    }
    class D7T3
    {
        static void Main(string[] args)
        {
            Ohjelma ohj1 = new Ohjelma { nimi = "muumit", kanava = "TV2", alkuaika = 8, loppuaika = 9, info = "muumit seikkailee" };
            Ohjelma ohj2 = new Ohjelma { nimi = "jattipotti", kanava = "MTV3", alkuaika = 8, loppuaika = 23, info = "voita tsiljoona euroa soita nyt heti" };
            List<Ohjelma> ohjelmat = new List<Ohjelma>();
            ohjelmat.Add(ohj1);
            ohjelmat.Add(ohj2);
            IFormatter formatter = new BinaryFormatter();
            foreach (Ohjelma o in ohjelmat)
            {
                Stream writeStream = new FileStream(o.nimi+".bin", FileMode.Create, FileAccess.Write, FileShare.None);
                
                formatter.Serialize(writeStream, o);
                writeStream.Close();
            }


            Stream readStream = new FileStream("jattipotti.bin", FileMode.Open, FileAccess.Read, FileShare.None);
            Ohjelma jattipotti = (Ohjelma) formatter.Deserialize(readStream);

            Console.WriteLine("nimi: {0}, kanava: {1}, alkuaika: {2}, loppuaika: {3}, info: {4}", jattipotti.nimi, jattipotti.kanava, 
                jattipotti.alkuaika, jattipotti.loppuaika, jattipotti.info);

            readStream = new FileStream("muumit.bin", FileMode.Open, FileAccess.Read, FileShare.None);
            Ohjelma muumit = (Ohjelma)formatter.Deserialize(readStream);

            Console.WriteLine("nimi: {0}, kanava: {1}, alkuaika: {2}, loppuaika: {3}, info: {4}", muumit.nimi, muumit.kanava,
                muumit.alkuaika, muumit.loppuaika, muumit.info);

        }
    }
}
