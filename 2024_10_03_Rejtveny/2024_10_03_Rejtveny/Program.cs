using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics.SymbolStore;

namespace _2024_10_03_Rejtveny
{
    internal class Program
    {
        private static int[,] feladvany = new int[10, 10];
        private static List<Megoldas> megoldasok = new List<Megoldas>();
        static void Main(string[] args)
        {
            Fajlbeolvasas();
            FajlbeolvasasMegoldasok();
            Feladat3();
            
            Console.ReadLine();
        }

        private static void Feladat3()
        {
            for (int i = 0; i < megoldasok.Count; i++)
            {
                if (!UgyanazE(megoldasok[i].megoldas, feladvany))
                //if (!megoldasok[i].UgyanazE(feladvany))
                {
                    Console.WriteLine(megoldasok[i].nev);
                }
            }
        }

        private static bool ugyanaze(int[,] megoldas, int[,] feladvany)
        {
            bool vege = false;
            int i = 0;
            while (i<megoldas.GetLength(1) && !vege)
            {
                if (sorbanvaneelteres(megoldas, feladvany, i))
                    vege = true;
                else
                    i++;
            }
            //return vege == false;
            return !vege;
        }

        static bool sorbanvaneelteres(int[,] megoldas, int[,] feladvany, int sor)
        {
            int j = 0;
            while (j < feladvany.GetLength(0) && (megoldas[sor, j] == feladvany[sor, j] || megoldas[sor, j] == 11))
                j++;
            return j < feladvany.GetLength(0);
        }

        static void FajlbeolvasasMegoldasok()
        {
            StreamReader f = new StreamReader("megoldas.txt");
            f.ReadLine();

            while (!f.EndOfStream)
            {
                int[,] sm = new int[10, 10];
                string nev = f.ReadLine();
                MatrixBeolvas(f,sm);
                //for (int i = 0; i < 10; i++)
                //{
                //    string[] st  = f.ReadLine().Split(' ');
                //    for (int j = 0; j < st.Length; j++)
                //    {
                //        sm[i, j] = Convert.ToInt32(st[j]);
                //    }
                //}
                Megoldas sv = new Megoldas(nev, sm);
                megoldasok.Add(sv);
            }

            f.Close();
        }

        static void Fajlbeolvasas()
        {
            StreamReader f = new StreamReader("feladvany.txt");
            MatrixBeolvas(f, feladvany);
            //for(int j = 0; j<10;j++)
            //{
            //    string[] st = f.ReadLine().Split(' ');
            //    for (int i = 0; i < st.Length; i++)
            //    {
            //        feladvany[j,i] = Convert.ToInt32(st[i]);
            //    }
            //}

            f.Close();
        }

        static void MatrixBeolvas(StreamReader f, int[,] matrix)
        {
            for (int i = 0; i < 10; i++)
            {
                string[] st = f.ReadLine().Split(' ');
                for (int j = 0; j < st.Length; j++)
                {
                    matrix[i, j] = Convert.ToInt32(st[j]);
                }
            }
        }

    }

    struct Megoldas {
        //adattagok
        public string nev;
        public int[,] megoldas;

        //konstruktor
        public Megoldas(string nev, int[,] matrix)
        {
            this.nev = nev;
            megoldas = matrix;
        }

        //public bool UgyanazE( int[,] feladvany)
        //{
        //    bool vege = false;
        //    int i = 0;
        //    while (i < megoldas.GetLength(1) && !vege)
        //    {
        //        if (SorbanVaneElteres(megoldas, feladvany, i))
        //            vege = true;
        //        else
        //            i++;
        //    }
        //    return !vege;
        //}

        //private bool SorbanVaneElteres(int[,] megoldas, int[,] feladvany, int sor)
        //{
        //    int j = 0;
        //    while (j < feladvany.GetLength(0) && (megoldas[sor, j] == feladvany[sor, j] || megoldas[sor, j] == 11))
        //        j++;
        //    return j < feladvany.GetLength(0);
        //}

    }
}
