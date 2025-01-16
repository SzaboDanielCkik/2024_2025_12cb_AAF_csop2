using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_01_16_Mukorcsolya
{
    internal class Versenyzo
    {
        public string nev, orszag;
        public double technikai, komponens;
        public int levonas;
        public double Osszpont
        {
            get { return technikai + komponens - levonas; }
        }

        public Versenyzo(string sor)
        {
            string[] st = sor.Replace('.',',').Split(';');
            nev = st[0];
            orszag = st[1];
            technikai = Convert.ToDouble(st[2]);
            komponens = Convert.ToDouble(st[3]);
            levonas = Convert.ToInt32(st[4]);
        }
    }
}
