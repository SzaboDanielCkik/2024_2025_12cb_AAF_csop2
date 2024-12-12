using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_20_Szuperhosok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kepregeny.Szereplok("adatok.txt");
            Kepregeny.SzereplokKiir();

            Console.ReadLine();
        }
    }
}
