using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace _2025_01_27_MagyarorszagHegyei
{
    internal class Hegy
    {
        public string Hegycsucs { get; set; }
        public string Hegyseg { get; set; }
        public int Magassag { get; set; }

        public Hegy(string sor)
        {
            string[] st = sor.Split(';');
            Hegycsucs = st[0];
            Hegyseg = st[1];
            Magassag = Convert.ToInt32(st[2]);
        }

        public static List<Hegy> Fajlbeolvasas(string path) 
        {
            List<Hegy> hegyek = new List<Hegy>();
            try
            {
                StreamReader sr = new StreamReader(path);
                sr.ReadLine();
                while (!sr.EndOfStream)
                    hegyek.Add(new Hegy(sr.ReadLine()));
                sr.Close();
                //Console.WriteLine("Sikeres Fájlbeolvasás");
            }
            catch(Exception e)
            {
                Console.WriteLine("Nem sikerült a fájlbeolvasás.");
                Console.WriteLine(e.Message) ;
            }
            return hegyek;
        }

    }
}
