using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_02_Pekseg
{
    internal class Kave :IArlap
    {
        private bool habosE;

        public Kave(bool habose)
        {
            habosE = habose;
        }

        public double MennyibeKerul()
        {
            return habosE ? 180*1.5 : 180;
        }

        public override string ToString()
        {
            return $"{(habosE ? "Habos" : "Nem habos")} kávé - {MennyibeKerul()} Ft";
        }

    }
}
