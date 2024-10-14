using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_10_10_Doga1Megoldas
{
    internal class Program
    {
        static List<Versenyzo> versenyzok = new List<Versenyzo>();
        static void Main(string[] args)
        {
            Fajlbeolvasas();
            Feladat5();

            Console.ReadLine();
        }

        static void Feladat5()
        {
            int maxi = 0;
            for (int i = 1; i < versenyzok.Count; i++)
            {
                if (versenyzok[i].Eredmeny() > versenyzok[maxi].Eredmeny())
                    maxi = i;
            }

            //Horvátország (CRO)
            //Egyesült Államok (USA)
            Versenyzo legjobb = versenyzok[maxi];
            Console.WriteLine(legjobb.nev);
            Console.WriteLine(legjobb.csoport);
            string[] sn = legjobb.nemzeteskod.Split('(');
            string kod = sn[sn.Length - 1];

            Console.WriteLine(legjobb.nemzeteskod);
            Console.WriteLine(legjobb.nev);
        }

        static void Fajlbeolvasas()
        {
            StreamReader f = new StreamReader("Selejtezo2012.txt");

            f.ReadLine();
            while (!f.EndOfStream)
            {
                string sor = f.ReadLine();
                Versenyzo sv = new Versenyzo(sor);
                versenyzok.Add(sv);
                //versenyzok.Add(new Versenyzo(f.ReadLine()));
            }

            f.Close();
        }
    }

    struct Versenyzo 
    {
        public string nev, csoport, nemzeteskod;
        public double d1, d2, d3;

        public Versenyzo(string sor): this()
        {
            string[] st = sor.Split(';');
            nev = st[0];
            csoport = st[1];
            nemzeteskod = st[2];
            d1 = Atalakit(st[3]);
            d2 = Atalakit(st[4]);
            d3 = Atalakit(st[5]);
        }

        double Atalakit(string st)
        {
            if (st == "X")
                return -2;
            else if (st == "-")
                return -1;
            else
                return Convert.ToDouble(st);
        }

        public double Eredmeny()
        {
            double max = d1;
            if (max < d2)
                max = d2;
            else if (max < d3)
                max = d3;

            return max;
        }
        
    }
}
