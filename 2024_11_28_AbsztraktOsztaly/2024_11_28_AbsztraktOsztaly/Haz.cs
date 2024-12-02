using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_28_AbsztraktOsztaly
{
    internal class Haz : Tervrajz
    {
        public Haz() {
            szelesseg *= 1.2;
        }

        public override void TeraszElhelyezese(int x, int y, int sz, int h)
        { 
            //terasz elhelyezése
        }
    }
}
