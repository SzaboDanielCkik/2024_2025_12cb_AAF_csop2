using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_12_Gepjarmu
{
    internal abstract class Jarmu
    {
        protected int aktSebesseg;
        private string rendszam;

        public Jarmu(int aktSebesseg, string rendszam)
        { 
            this.aktSebesseg = aktSebesseg;
            this.rendszam = rendszam;
        }

        public abstract bool GyorshajtottE(int sebessegKorlat);

        public override string ToString()
        {
            return $"{rendszam} - {aktSebesseg} km/h";
        }

    }
}
