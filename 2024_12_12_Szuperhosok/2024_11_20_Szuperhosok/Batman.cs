using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_20_Szuperhosok
{
    internal class Batman : ISzuperhos, IMilliardos
    {
        public double lelemenyesseg;

        public Batman()
        {
            lelemenyesseg = 100;
        }

        public void KutyutKeszit()
        {
            lelemenyesseg += 50;
        }

        public bool LegyoziE(ISzuperhos ellenfel)
        {
            return ellenfel.MekkoraAzEreje() < lelemenyesseg;
        }

        public double MekkoraAzEreje()
        {
            return lelemenyesseg * 2;
        }

        public override string ToString()
        {
            return $"[Batman]: leleményesség: {lelemenyesseg} ereje: {MekkoraAzEreje()}";
        }
    }
}
