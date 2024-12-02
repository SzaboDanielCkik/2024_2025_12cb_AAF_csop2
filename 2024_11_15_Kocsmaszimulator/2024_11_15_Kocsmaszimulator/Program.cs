using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_15_Kocsmaszimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kocsmaros a1 = new Kocsmaros(50);
            Ember e1 = new Ember("Imre", 22, true, 100);
            Console.WriteLine( e1.ToString());
            e1.Iszik(a1);
            e1.ToString();
            e1.Jon();
            e1.Iszik(a1);
            Console.WriteLine(e1.ToString());
            Console.WriteLine(a1.ToString());
            Ital i1 = new Ital(5, 6);
            e1.Iszik(a1, i1);
            Console.WriteLine(e1.ToString());
            Console.WriteLine(a1.ToString());


            Console.ReadLine();
        }
    }
}
