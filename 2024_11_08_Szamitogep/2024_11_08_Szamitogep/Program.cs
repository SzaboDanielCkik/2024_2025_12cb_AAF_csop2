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


            Console.ReadLine();
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
