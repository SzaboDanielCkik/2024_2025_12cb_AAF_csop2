using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_09_04_Ismetles1
{
    internal class Program
    {
        /* Ismétlés
             * Vezérlő szerkezetek (utasítás, elágazás, ciklus)
             * Programozási tételek
             * Metódusok (függvény, eljárás) - minden, ami nem kiíratás, az függvény
             * Struktúra (struct)
             * Osztályok (class)
             * Öröklődés + scope
             * Fájlbeolvasás */

            /* Jancsi és Juliska szerencse kockáznak. 
             * Itt a számok 1-30ig vannak, de minden néggyel osztható szám hiányzik.
             * (1,2,3,5,6,7,9,10,11...)
             * Írjon alkalmazást, ami kigenerál mindkettőjüknek 10-10 dobást!
             * Adja meg, hogy ki dobta a legtöbbször a legnagyobb számot!*/
            // Írjon egy fv-t, ami egy számról eldönti, hogy prím-e!

        static List<int> t = new List<int>();
        static void Main(string[] args)
        {
            Feltoltes();
            Kiiratas();
            Feladat();
            //Console.WriteLine(PrimE(1));
            Feladat2();
            Console.ReadLine();
        }

        static void Feladat2()
        {
            Console.WriteLine("A dobot számok között {0} prím van.", DarabPrimek());
        }

        static int DarabPrimek() {
            int db = 0;
            for (int i = 0; i < t.Count; i++)
            {
                if (PrimE(t[i]))
                    db++;
            }
            return db;
        }

        static bool PrimE(int szam)
        {
            if (szam < 2)
                return false;
            int i = 2;
            while (i <= szam / 2 && szam % i != 0)
                i++;
            return i > szam / 2;
        }


        static void Kiiratas()
        {
            JatekosKiiratasa(0);
            JatekosKiiratasa(1);
            

            //for (int i = 0; i < t.Count; i+=2) {
            //    Console.Write(t[i]+" ");
            //}
            //Console.WriteLine();
            //for (int i = 1; i < t.Count; i += 2)
            //{
            //    Console.Write(t[i] + " ");
            //}
            //Console.WriteLine();
        }

        static void JatekosKiiratasa(int start)
        {
            for (int i = start; i < t.Count; i += 2)
            {
                Console.Write(t[i] + " ");
            }
            Console.WriteLine();
        }

        static void Feladat()
        {
            int max = Maximum();
            int jancsiDb = Darabszamol(0, max);
            int juliskaDb = Darabszamol(1, max);
            if (jancsiDb > juliskaDb) {
                Console.WriteLine("Jancsi dobta többször a legnagyobb számot");
            }
            else if(jancsiDb < juliskaDb){
                Console.WriteLine("Juliska dobta többször a legnagyobb számot");
            }
            else
            {
                Console.WriteLine("Ugyan annyit dobtak");
            }
        }

        static int Darabszamol(int start, int max)
        {
            int db = 0;
            for (int i = start; i < t.Count; i += 2)
            {
                if (t[i] == max)
                    db++;
            }
            return db;
        }

        static int Maximum() {
            int maxe = 0;
            for (int i = 0; i < t.Count; i++)
            {
                if(maxe < t[i])
                    maxe = t[i];
            }
            return maxe;
        }

        static void Feltoltes() {
            Random r = new Random();
            int i = 0;
            while (i<20) { 
                int a = r.Next(1,31);                
                if (a % 4 != 0) { 
                    t.Add(a);
                    i++;
                }
            }
        }
    }
}
