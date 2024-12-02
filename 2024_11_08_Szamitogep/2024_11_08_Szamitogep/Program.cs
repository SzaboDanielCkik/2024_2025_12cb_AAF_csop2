using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_08_Szamitogep
{
    internal class Program
    {
        static List<Szamitogep> szamitogepek = new List<Szamitogep>();

        static void Main(string[] args)
        {      
            Feladat0();
            Fajlbeolvasas();
            Feladat2();
            Feladat3();
            Szamitogep.konyvelo = "";


            Console.ReadLine();
        }

        private static void Feladat3()
        {
            int index = MaximumIndex();
            bool sv = szamitogepek[index].bekapcsolva;
            Console.WriteLine($"{(sv?"Be ":"Ki ")}van kapcsolva");
            //Console.WriteLine(szamitogepek[index].memoria);
        }

        private static int MaximumIndex()
        {
            int maxi = 0;
            for (int i = 1; i < szamitogepek.Count; i++) {
                if (szamitogepek[i].memoria > szamitogepek[maxi].memoria)
                    maxi = i;
            }
            return maxi;
        }

        private static void Feladat2()
        {
            int darab = BekapcsoltGepekDb();
            Console.WriteLine($"{darab} darab bekapcsolt számítógép van.");
        }

        private static int BekapcsoltGepekDb()
        {
            int db = 0;
            for (int i = 0; i < szamitogepek.Count; i++) {
                if (szamitogepek[i].bekapcsolva)
                    db++;
            }
            return db;
        }

        private static void Fajlbeolvasas()
        {
            StreamReader f = new StreamReader("Szamitogep.txt");

            f.ReadLine();
            while (!f.EndOfStream) {
                string[] st = f.ReadLine().Split('\t');
                szamitogepek.Add(new Szamitogep(Convert.ToInt32(st[0]), st[1] == "x"));
            }
            f.Close();
        }

        private static void Feladat0()
        {
            Szamitogep sz1 = new Szamitogep();
            Szamitogep sz2 = new Szamitogep(2048, false);

            Console.WriteLine(sz1.ToString());
            Console.WriteLine(sz2.ToString());

            sz1.Kapcsol();
            ProgramMasolas(sz1, 800);
            ProgramMasolas(sz1, 400);
            sz2.Kapcsol();
            ProgramMasolas(sz2, 1);           

            Console.WriteLine();
        }

        static void ProgramMasolas(Szamitogep sz, double hely)
        {
            if (sz.ProgramMasol(hely))
            {
                Console.WriteLine("Sikerült a másolás.");
            }
            else
            {
                Console.WriteLine("Nem sikerült a másolás.");
            }
            Console.WriteLine(sz.ToString());
        }
    }
}
