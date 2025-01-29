using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_01_27_MagyarorszagHegyei
{
    internal class Program
    {
        static List<Hegy> hegyek = new List<Hegy>();
        static void Main(string[] args)
        {
            Fajlbeolvasas();

            if (hegyek.Count>0) {
                Feladat3();
                Feladat4();
                Feladat5();
                Feladat6();
                Feladat7();
                Feladat8();
                Feladat9();
            }

            

            Console.ReadLine();
        }

        private static void Feladat9()
        {
            string path = "bukk-videk.txt";
            StreamWriter sw = new StreamWriter(path);
            Console.WriteLine("9. feladat: "+path);
            var adatKiiratasra = hegyek.Where(x => x.Hegyseg == "Bükk-vidék")
                .Select(x => new
                {
                    hegycsucs = x.Hegycsucs,
                    magassag = x.Magassag * 3.280839895
                });

            sw.WriteLine("Hegyúcs neve;Magasság láb");
            foreach (var hegy in adatKiiratasra)
            {
                sw.WriteLine($"{hegy.hegycsucs};{(""+Math.Round(hegy.magassag,1)).Replace(',','.')}");
            }

            sw.Close();
        }

        private static void Feladat8()
        {
            Console.WriteLine("8. feladat: Hegység statisztika");
            var statisztika = hegyek
                .GroupBy(x => x.Hegyseg);
                //.Select(x => new
                //{
                //    hegyseg = x.Key,
                //    darab = x.Count(),
                //    atlag = x.Average(c=>c.Magassag)
                //});
            foreach (var hegy in statisztika)
            {
                //Console.WriteLine($"{hegy.hegyseg} - {hegy.darab} db");
                //Console.WriteLine($"{hegy.Key} - {hegy.Average(x=>x.Magassag)} db");
                Console.WriteLine($"\t{hegy.Key} - {hegy.Count()} db");
            }
        }

        private static void Feladat7()
        {
            Console.WriteLine($"7. feladat: 3000 lábnál magasabb hegycsúcsok száma: {hegyek.Where(c=>c.Magassag*3.280839895>3000).Count()}");
        }

        private static void Feladat6()
        {
            Console.Write("6. feladat: Kérek egy magasságot: ");
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());
                bool vane = hegyek.Any(x => x.Hegyseg == "Börzsöny" && x.Magassag > n);
                Console.WriteLine($"\t{(vane? "Van ": "Nincs ")}{n}-nél magasabb hegycsúcs a Börzsönyben!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Rossz adatot adtál meg!");
                Feladat6();
            }
        }

        private static void Feladat5()
        {
            Console.WriteLine("5. feladat: A legmagasabb hegycsúcs adatai: ");
            var legmagasabb = hegyek.Find(c => c.Magassag == hegyek.Max(x => x.Magassag));
            //var legmagasabb = hegyek.OrderBy(x => x.Magassag).Last();
            //var legmagasabb = hegyek.OrderByDescending(x => x.Magassag).First();
            Console.WriteLine("\tNév: "+legmagasabb.Hegycsucs);
            Console.WriteLine("\tHegység: "+legmagasabb.Hegyseg);
            Console.WriteLine("\tMagasság: "+legmagasabb.Magassag+" m");
        }

        private static void Feladat4()
        {
            Console.Write("4. feladat: Hegycsúcsok átlagos magassága: ");
            Console.WriteLine(hegyek.Average(x=>x.Magassag) +" m");
        }

        private static void Feladat3()
        {
            Console.Write("3. feladat: Hegycsúcsok száma: ");
            Console.WriteLine(hegyek.Count +" db");
        }

        private static void Fajlbeolvasas()
        {
            hegyek = Hegy.Fajlbeolvasas("hegyekMo2.txt");
        }
    }
}
