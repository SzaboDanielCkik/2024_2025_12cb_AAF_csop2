using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_01_10_Valasztasok
{
    internal class Program
    {
        static List<Kepviselo> kepviselok = new List<Kepviselo>();
        static void Main(string[] args)
        {
            Fajlbeolvasas();
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
            Feladat7();

            //GroupBy
            //Csoportositas();


            Console.ReadLine();
        }

        private static void Feladat7()
        {
            var csoportositas = kepviselok.GroupBy(c => c.Sorszam)
                .Select(x => new
                {
                    kerulet = x.Key,
                    kepviselo = x.ToList().Find(v=>v.Szavazat == x.Max(d => d.Szavazat))
                })
                .OrderBy(c => c.kerulet);
            foreach (var item in csoportositas)
                //Console.WriteLine(item.partNeve+" "+item.osszeg);
                Console.WriteLine(item.kerulet + " " + item.kepviselo.Vezeteknev + " " + item.kepviselo.Keresztnev);
        }

        private static void Csoportositas()
        {
            // Adja meg hány képviselő van az adott párnál!
            //var csoportositas = kepviselok
            //    .GroupBy(c => c.Part)
            //    .Select(x=> new
            //    {
            //        partNeve = x.Key,
            //        darab = x.Count()
            //    });

            //Az adott párt hány szavazatot kapott. Szavazat alapján csökkenő sorrendben.
            //var csoportositas = kepviselok
            //    .GroupBy(c => c.Part)
            //    .Select(x => new
            //    {
            //        partNeve = x.Key,
            //        osszeg = x.Sum(d=>d.Szavazat)
            //    })
            //    .OrderByDescending(k=>k.osszeg);

            //Választókerületenként  a legnagyobb érték
            var csoportositas = kepviselok.GroupBy(c => c.Sorszam)
                .Select(x => new
                {
                    kerulet = x.Key,
                    maxe = x.Max(d => d.Szavazat)
                })
                .OrderBy(c=>c.kerulet);
            foreach (var item in csoportositas)
                //Console.WriteLine(item.partNeve+" "+item.osszeg);
                Console.WriteLine(item.kerulet+" "+item.maxe);
        }

        private static void Feladat6()
        {
            Console.WriteLine("6. feladat");
            int maxSzavazat = kepviselok.Max(c => c.Szavazat);
            var legjobbKepviselok = kepviselok.Where(c => c.Szavazat == maxSzavazat);
            foreach (var item in legjobbKepviselok)
                Console.WriteLine(item.Vezeteknev+" "+item.Keresztnev+" "+item.Szavazat);
        }

        private static void Feladat5()
        {
            List<string> partSzoveg = new List<string> {"Gyümölcsevők Pártja", "GYEP", "Húsevők Pártja", "HEP", "Tejivók Szövetsége", "TISZ", "Zöldségevők Pártja", "ZEP", "Független jelöltek", "-"};
            Console.WriteLine("5. feladat");
            var partok = kepviselok.Select(x => x.Part).Distinct();
            foreach (var elem in partok)
            {
                /*int / int = int
                 * 5 / 10 = 0 
                 * double / int = double
                 * 5.0 / 10 = 0.5 */
                double szazalek = (double) kepviselok.FindAll(x=>x.Part == elem).Sum(x=>x.Szavazat)/ kepviselok.Sum(x => x.Szavazat)*100;
                Console.WriteLine($"{partSzoveg[partSzoveg.IndexOf(elem)-1]} = {Math.Round(szazalek,2)}%");
            }
        }

        private static void Feladat4()
        {
            Console.WriteLine("4. feladat");
            int sum = kepviselok.Sum(x => x.Szavazat);
            double szazalek = (double)sum / 12345 * 100;
            Console.WriteLine($"\tA választáson {sum} állampolgár, a jogosultak {Math.Round(szazalek,2)}%-a vett részt.");
        }

        private static void Feladat3()
        {
            Console.WriteLine("3. feladat");
            Console.Write("\tAdja meg a képviselő nevét: ");
            string[] nev = Console.ReadLine().Split(' ');
            Kepviselo k = kepviselok.Find(c => c.Vezeteknev == nev[0] && c.Keresztnev == nev[1]);
            if(k == null)
                Console.WriteLine("\tIlyen nevű képviselőjelölt nem szerepel a nyilvántartásban!");
            else
                Console.WriteLine($"\t{nev[0]} {nev[1]} képviselő {k.Szavazat} szavazatot kapott.");            
        }

        private static void Feladat2()
        {
            Console.WriteLine("2. feladat");
            Console.WriteLine($"\tA helyhatósági választáson {kepviselok.Count} képviselőjelölt indult.");
        }

        private static void Fajlbeolvasas()
        {
            StreamReader sr = new StreamReader("szavazatok.txt");

            while (!sr.EndOfStream)
            {
                Kepviselo sv = new Kepviselo(sr.ReadLine());
                kepviselok.Add(sv);
            }

            sr.Close();

        }
    }
}
