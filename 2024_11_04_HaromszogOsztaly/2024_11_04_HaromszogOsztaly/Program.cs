using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_04_HaromszogOsztaly
{
    internal class Program
    {
        static List<Haromszog> haromszogek = new List<Haromszog>();
        static void Main(string[] args)
        {
            Fajlbeolvasas();
            Feladat1(); //365
            Feladat2();
            Feladat3();


            Console.ReadLine();
        }

        private static void Feladat3()
        {
            if(VanESzabalyosHaromszog())
                Console.WriteLine("Van benne szabályos háromszög.");
            else
                Console.WriteLine("Nincs benne szabályos háromszög.");
        }

        private static bool VanESzabalyosHaromszog()
        {
            int i = 0;
            while (i < haromszogek.Count && !haromszogek[i].SzabolyosE()) 
                i++;
            return i < haromszogek.Count;
        }

        private static void Feladat2()
        {
            int index = MaxTeruletuHaromszogIndexe();
            Haromszog sv = haromszogek[index];
            Console.WriteLine("Max teruletu haromszog oldalai: a={0} b={1} c={2}",sv.A,sv.B,sv.C);
        }

        private static int MaxTeruletuHaromszogIndexe()
        {
            int maxi = 0;
            for (int i = 1; i < haromszogek.Count; i++)
            {
                if (haromszogek[i].SzerkeszthetoE() && haromszogek[i].Terulet() > haromszogek[maxi].Terulet())
                    maxi = i;
            }
            return maxi;
        }

        private static void Feladat1()
        {
            Console.WriteLine("{0} darab nem szerkeszthető háromszög van a listában", NemszerkeszthetoHaromszogek());
        }

        private static int NemszerkeszthetoHaromszogek()
        {
            int db = 0;
            for (int i = 0; i < haromszogek.Count; i++)
            {
                if (!haromszogek[i].SzerkeszthetoE())
                    db++;
            }
            return db;
        }

        private static void Fajlbeolvasas()
        {
            StreamReader f = new StreamReader("haromszogek.txt");

            f.ReadLine();
            while (!f.EndOfStream) {
                Haromszog sh = new Haromszog(f.ReadLine());
                haromszogek.Add(sh);
                //haromszogek.Add(new Haromszog(f.ReadLine()));
            }

            f.Close();
        }
    }
}
