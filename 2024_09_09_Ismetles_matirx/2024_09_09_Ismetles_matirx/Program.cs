using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _2024_09_09_Ismetles_matirx
{
    internal class Program
    {
        static int[,] matrix;

        static void Main(string[] args)
        {
            MatrixHosszBekeres();
            MatrixFeltoltes();
            MatrixKiirat();

            Feladat1();
            /* Adja meg annak az elemnek a sorát és oszlopát, melyiknek a szomszédjainak átlaga a legnagyobb!*/
            Feladat2();
            Console.ReadLine();
        }

        static void Feladat2()
        {
            //int[] maxok = LegnagyobbAtlaguSzomszed()
            (int maxSor, int maxOszlop) = LegnagyobbAtlaguSzomszed();
            Console.WriteLine("A {0}. sorban és {1}. található az az elem, amelyik szoszomdjainek átlaga a legnagyobb.", maxSor, maxOszlop);
        }

        static (int, int) LegnagyobbAtlaguSzomszed()
        {
            int maxi = 0; 
            int maxj = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    //List<int> szomszedok = SzomszedKigyujt(i, j);
                    //double atlagAkt = szomszedok.Sum() / szomszedok.Count;
                    //List<int> szomszedokmax = SzomszedKigyujt(maxi, maxj);
                    //double atlagMax = szomszedokmax.Sum() / szomszedokmax.Count;
                    double atlagAkt = Atlag(SzomszedKigyujt(i,j));
                    double atlagMax = Atlag(SzomszedKigyujt(maxi,maxj));
                    if (atlagAkt > atlagMax )
                    {
                        maxi = i;
                        maxj = j;
                    }
                }
            }
            return (maxi, maxj);
        }

        static double Atlag(List<int> lista)
        { 
            return lista.Sum()/lista.Count();
        }

        static void Feladat1()
        {
            Console.WriteLine();
            Console.Write("Adja meg a kívánt sorszámát: ");
            int sor = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write("Adja meg a kívnát oszlopszámát: ");
            int oszlop = Convert.ToInt32(Console.ReadLine()) - 1;

            List<int> szomszedok = SzomszedKigyujt(sor, oszlop);

            ListaKiirat(szomszedok);


        }

        static void ListaKiirat(List<int> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write(lista[i]+" ");
            }
            Console.WriteLine();
        }

        static List<int> SzomszedKigyujt(int s, int o) {
            List<int> szomszedok = new List<int>();
            for (int i = -1; i < 2; i++) {
                for (int j = -1; j < 2; j++)
                {
                    //if(s+i>-1 && o+j>-1 && s+i<matrix.GetLength(0) && o+j<matrix.GetLength(1))
                    if (s + i > -1 && o + j > -1 && s + i < matrix.GetLength(0) && o + j < matrix.GetLength(1) && (i != 0 || j != 0))
                    {
                        //Console.Write(matrix[s+i, o+j]+" ");
                        szomszedok.Add(matrix[s + i, o + j]);
                    }
                    //  !(i == 0 && j == 0)
                    //  i != 0 || j != 0
                }
                //Console.WriteLine();
            }
            return szomszedok;
        }

        private static void MatrixKiirat()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(Megjelenites(matrix[i,j]));
                    
                }
                Console.WriteLine();
            }
        }

        static string Megjelenites(int a)
        {
            if (a < 10) return "   " + a;
            if (a < 100) return "  " + a;
            return " " + a;
        }

        private static void MatrixFeltoltes()
        {
            Random r = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(1000);
                }
            }
        }

        private static void MatrixHosszBekeres()
        {
            Console.Write("Adja a mátrix sorát: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja a mátrix oszlopát: ");
            int m = Convert.ToInt32(Console.ReadLine());
            matrix = new int[n, m];
        }
    }
}


//int a = 1;
//int b = 12;
//int c = 123;
//Console.WriteLine(a.ToString().PadLeft(4));
//Console.WriteLine(b.ToString().PadLeft(4));
//Console.WriteLine(c.ToString().PadLeft(4));
//Console.Write(a.ToString().PadRight(4));
//Console.Write(b.ToString().PadRight(4));
//Console.Write(c.ToString().PadRight(4));
//Console.Write("vége");
//Console.WriteLine();

//Console.Write(matrix[i,j].ToString().PadLeft(4));