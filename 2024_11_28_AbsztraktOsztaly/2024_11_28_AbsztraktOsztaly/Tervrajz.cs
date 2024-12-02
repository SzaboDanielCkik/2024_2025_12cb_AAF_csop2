using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_28_AbsztraktOsztaly
{
    internal abstract class Tervrajz
    {
        public double szelesseg { get; protected set; }
        public double hossz { get; protected set; }

        public void HazElhelyezeseTelken(int x, int y)
        { 
            //Ház elhelyezése
        }

        public abstract void TeraszElhelyezese(int x, int y, int sz, int h);
    }
}
