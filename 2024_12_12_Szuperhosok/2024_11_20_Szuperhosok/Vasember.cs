using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_20_Szuperhosok
{
    internal class Vasember:Bosszuallo, IMilliardos
    {
        //Konstruktor
        public Vasember():base(150, true){}

        public void KutyutKeszit()
        {
            Random r = new Random();
            Szuperero += r.NextDouble() * 10;
        }

        public override bool MegmentiAVilagot()
        {
            return Szuperero > 1000;
        }

        public override string ToString()
        {
            return "[Vasember]:" + base.ToString();
        }
    }
}
