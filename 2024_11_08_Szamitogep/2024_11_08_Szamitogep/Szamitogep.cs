using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_08_Szamitogep
{
    internal class Szamitogep
    {
        public static string konyvelo;

        // Adattagok
        public double memoria;
        public bool bekapcsolva;

        // Konstruktor
        public Szamitogep(double memo, bool bekapcsol) {
            memoria = memo;
            bekapcsolva = bekapcsol;
        }

        public Szamitogep()
        {
            memoria = 1024;
            bekapcsolva = false;
        }

        // Metódusok
        public void Kapcsol()
        {
            //if (bekapcsolva)
            //    bekapcsolva = false;
            //else
            //    bekapcsolva = true;
            bekapcsolva = !bekapcsolva;
        }

        public bool ProgramMasol(double program)
        {
            if (bekapcsolva && memoria - program >= 0)
            {
                memoria -= program;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return string.Format("{0} Szabad memória: {1}",
                bekapcsolva ? "Be van kapcsolva" : "Ki van kapcsolva", memoria);
        }
    }
}
