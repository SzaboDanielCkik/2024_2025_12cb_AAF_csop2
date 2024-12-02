using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_25_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //polimorfizmus - többalakúság. Egy osztályt több, különböző példányokat tud tárolni. (Ha közös az ős)
            IFenykepezo f1 = new Osztaly();
            IFenykepezo f2 = new Mobil();

            //Console.WriteLine(f1.GetType());

            if (f1.GetType() == typeof(Mobil))
                f1.FenykepetKeszit(3);
            else
                ((Mobil)f1).Hangrogzites("valami");


            Console.ReadLine();
        }
    }
}
