using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_02_Pekseg
{
    internal class Pogacsa : Peksutemeny
    {

        public Pogacsa(double mennyiseg, double alapar):base(mennyiseg,
            alapar)
        { }

        public override void Megkostol()
        {
            mennyiseg /= 2;
        }

        public override string ToString()
        {
            return "pogácsa: "+base.ToString();
        }
    }
}
