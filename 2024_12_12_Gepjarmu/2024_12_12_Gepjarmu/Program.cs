using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_12_Gepjarmu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Orszagut.JarmuvekJonnek("adatok.txt");
            Orszagut.KiketMertunkBe();

            Console.ReadLine();
        }
    }
}
