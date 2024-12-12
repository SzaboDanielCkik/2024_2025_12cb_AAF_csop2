using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_12_Gepjarmu
{
    internal class AudiS8 : Jarmu
    {
        public bool lezerblokkolo;

        public AudiS8(bool lezerblokkolo, int aktSebesseg, string rendszam): base(aktSebesseg,rendszam)
        {
            this.lezerblokkolo = lezerblokkolo;
        }

        public override bool GyorshajtottE(int sebessegKorlat)
        {
            return aktSebesseg > sebessegKorlat && !lezerblokkolo;
        }


        public override string ToString()
        {
            return "AudiS8: " + base.ToString();
        }
    }
}
