using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _2024_10_04_Osztaly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Felhasznalo f1 = new Felhasznalo("szabdan", Jelszo());
            Console.WriteLine(f1.ToString());
            //f1.jelszo = "987654";
            //f1.SetAzon("Béla");
            Console.WriteLine(f1.Azon);
            Console.WriteLine(f1.ToString());
            Console.WriteLine(f1.Pin);

            Felhasznalo f2 = new Felhasznalo("kiskutya");
            Console.WriteLine(f2.ToString());

            Console.ReadLine();
        }

        static string Jelszo()
        {
            Console.Write("Jelszo: ");
            string sz = "";

            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.Enter:
                        return sz;
                    case ConsoleKey.Backspace:
                        if (sz.Length > 0)
                        {
                            sz = sz.Substring(sz.Length - 1);
                            Console.Write("\b \b");
                        }
                        break;
                    default:
                        sz += key.KeyChar;
                        Console.Write("*");
                        break;
                }
            } while (key.Key != ConsoleKey.Enter);

            return sz;
        }

    }



    class Felhasznalo
    {
        private string azon, jelszo;
        

        public Felhasznalo(string azon, string jelszo = "valami1234")
        {
            this.azon = azon;
            this.jelszo = jelszo;
            Pin = 1234;
        }

        //get,set

        public string Azon { get {
                return azon;
            }
            //set {
            //    azon = value;
            //}
        }

        public int Pin { get; private set; }

        //public string GetAzon()
        //{
        //    return azon;
        //}

        //public void SetAzon(string ujazon)
        //{
        //    azon = ujazon;
        //}

        public override string ToString()
        {
            return azon + " " + jelszo;
        }
    }
}
