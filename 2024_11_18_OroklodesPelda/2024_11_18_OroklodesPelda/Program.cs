using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_18_OroklodesPelda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kutya k = new Kutya();
            k.Ugat();

            Puli p = new Puli();
            p.Ugat();
            p.Terel();

            //Kutya k = new Puli();
            k = p;
            k.Ugat();
            ((Puli)k).Terel();

            Console.ReadLine();
        }
    }

    class Kutya //Ős osztály
    {
        public void Ugat()
        {
            Console.WriteLine("Vau-vau");
        }
    }


    class Puli: Kutya //Kutyából származtatott utód osztály. Csak egy ősosztály lehet!
    {
        public void Terel()
        {
            Console.WriteLine("Gyerünk, indulás lusta banda!");
        }
    }
}
