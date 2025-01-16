using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_01_16_Mukorcsolya
{
    internal class Program
    {
        static List<Versenyzo> donto = new List<Versenyzo>();
        static List<Versenyzo> rovidprogram = new List<Versenyzo>();
        static void Main(string[] args)
        {
            donto = Fajlbeolvasas("donto.csv");
            rovidprogram = Fajlbeolvasas("rovidprogram.csv");

            Feladat2();
            Feladat3();
            Feladat5_6();
           

            Console.ReadLine();
        }

        private static void Feladat5_6()
        {
            Console.WriteLine("5. feladat");
            Console.Write($"\tKérem a versenyző nevét: ");
            string nev = Console.ReadLine();
            Console.WriteLine("6. feladat");
            Console.WriteLine($"\tA versenyző összpontszáma: {OsszpontSzam(nev)}");
        }

        private static double OsszpontSzam(string nev)
        {
            var versenyzoR = rovidprogram.Find(x=>x.nev == nev);
            if (versenyzoR == null) return -1;
            var versenyzoD = donto.Find(x=>x.nev == nev);
            if (versenyzoD == null) return versenyzoR.Osszpont;
            return versenyzoR.Osszpont + versenyzoD.Osszpont;
        }

        private static void Feladat3()
        {
            Console.WriteLine("3. Feladat");
            bool vanEMagyar = donto.Any(x => x.orszag == "HUN");
            if(vanEMagyar )
                Console.WriteLine("A magyar versenyző bejutott a kűrbe");
            else
                Console.WriteLine("A magyar versenyző nem jutott be a kűrbe");
        }

        private static void Feladat2()
        {
            Console.WriteLine("2. Feladat");
            Console.WriteLine($"\tA rövid programban {rovidprogram.Count} induló volt.");
        }

        private static List<Versenyzo> Fajlbeolvasas(string path)
        {
            List<Versenyzo> versenyzok = new List<Versenyzo>();
            StreamReader sr = new StreamReader(path);
            sr.ReadLine();
            
            while (!sr.EndOfStream)
            {
                Versenyzo v = new Versenyzo(sr.ReadLine());
                versenyzok.Add(v);
            }

            sr.Close();
            return versenyzok;
        }
    }


}
