using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_02_Pekseg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Peksutemeny p = new Peksutemeny(12, 13);

            //Console.WriteLine(p.ToString());

            //Pogacsa p = new Pogacsa(12, 350);
            //Console.WriteLine(p.ToString());

            //Kave kv = new Kave(true);
            //Console.WriteLine(kv);

            Pekseg.Vasarlok("termekek.txt");
            Pekseg.EtelLeltar();

            Console.ReadLine();
        }
    }
}
