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

            Console.WriteLine(OsszpontSzam("Xiangning LI"));

            Feladat2();
            Feladat3();
            Feladat5_6();
            Feladat7();
            // Írassa ki a legjobb versenyzőket országonként (ahol 1-nél többb versenyző volt)
            Feladat7_1();
            Feladat8();

            Console.ReadLine();
        }

        private static void Feladat8()
        {
            StreamWriter sw = new StreamWriter("vegeredmeny.csv");
            var csoportositas = rovidprogram.Select(x => new
            {
                nev = x.nev,
                orszag = x.orszag,
                osszpont = OsszpontSzam(x.nev)
            })
                .OrderByDescending(x=>x.osszpont);
            int i = 1;
            foreach (var item in csoportositas)
            {
                sw.WriteLine($"{i};{item.nev};{item.orszag};{item.osszpont} ");
                i++;
            }
            sw.Close();
        }

        private static void Feladat7_1()
        {
            var csoportositas = donto.GroupBy(versenyzo => versenyzo.orszag)
                .Where(obj => obj.Count() > 1)
                .Select(obj => new
                {
                    orszagkod = obj.Key,
                    legjobb = obj.ToList().Find(c => c.Osszpont == obj.Max(x => x.Osszpont))
                });
                

            foreach (var item in csoportositas)
            {
                Console.WriteLine($"{item.orszagkod} - {item.legjobb.nev}: {item.legjobb.Osszpont} ");
            }
        }

        private static void Feladat7()
        {
            var csoportositas = donto.GroupBy(versenyzo => versenyzo.orszag)
                .Select(obj => new
                {
                    orszagkod = obj.Key,
                    darab = obj.Count()
                }).
                Where(x=>x.darab>1);

            foreach (var item in csoportositas)
            {
                Console.WriteLine($"{item.orszagkod} {item.darab}");
            }
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
