using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_25_Interface
{
    internal class Mobil : IFenykepezo, IDigtafon
    {
        public void FenykepetKeszit(int valtozo)
        {
            Console.WriteLine(valtozo+" Mobillal készített kép.");
        }

        public void Hangrogzites(string szoveg)
        {
            Console.WriteLine("Mobillal rögzített hang.");
        }
    }
}
