using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_12_Gepjarmu
{
    internal class Robogo: Jarmu, IKisGepjarmu
    {
        public int maxSebesseg;

        public Robogo(int maxSebesseg, int sebesseg, string rendszam) : base(sebesseg, rendszam)
        {
            this.maxSebesseg = maxSebesseg;
        }

        public override bool GyorshajtottE(int sebessegKorlat)
        {
            return aktSebesseg > sebessegKorlat;
        }

        public bool HaladhatItt(int sebesseg)
        {
            return maxSebesseg <= sebesseg;
        }
        public override string ToString()
        {
            return "Robogo: "+ base.ToString();
        }
    }
}
