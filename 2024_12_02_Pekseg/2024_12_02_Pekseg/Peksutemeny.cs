using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_02_Pekseg
{
    internal abstract class Peksutemeny :IArlap
    {
        protected double mennyiseg;
        private double ar;

        public Peksutemeny(double mennyiseg, double ar)
        {
            this.mennyiseg = mennyiseg;
            this.ar = ar;
        }

        public abstract void Megkostol();

        public double MennyibeKerul()
        {
            return ar * mennyiseg;
        }

        public override string ToString()
        {
            return $"{mennyiseg} db - {MennyibeKerul()} Ft";
        }
    }
}
