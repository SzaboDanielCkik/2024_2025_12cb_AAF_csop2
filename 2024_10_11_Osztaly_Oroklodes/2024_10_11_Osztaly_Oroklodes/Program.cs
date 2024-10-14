using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_10_11_Osztaly_Oroklodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Hozzon létre egy Dolgozo nevu osztalyt.
                    - Név (konstruktorban, lekérdezhető, nem módosítható)
                    - aktív (konstruktorban - alapértelmezett True, lekérdezhető)
                    - évek, amióta a cégnél dolgozik (konstruktorban - alapértelmezett 0, lekérdezhető)

                Metódusok:
                    - FV: Módosítja az aktív állapotot!
                    - FV: növeli eggyel az évek számát!
                    - FV: ToString();

                Töltsön fel egy tömböt dolgozókkal! Majd jelenítse meg őket!
             */

        }
    }

    class Dolgozo
    {
        private string nev;
        private bool aktiv;
        private int evek;

        public Dolgozo(string nev, bool aktiv = true, int evek = 0)
        {
            this.nev = nev;
            this.aktiv = aktiv;
            this.evek = evek;
        }

        public string Nev { get { return nev;} }
    }
}
