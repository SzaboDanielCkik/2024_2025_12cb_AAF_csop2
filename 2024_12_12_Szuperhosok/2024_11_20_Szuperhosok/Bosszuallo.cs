using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_20_Szuperhosok
{
    internal abstract class Bosszuallo:ISzuperhos
    {
        //Adattagok
        private double szuperero;
        private bool vanEGyengesege;

        //Konstruktor
        public Bosszuallo(double szuperero, bool vanEGyengesege) 
        { 
            this.szuperero = szuperero;
            this.vanEGyengesege = vanEGyengesege;
        }

        //Metódusok
        public abstract bool MegmentiAVilagot();

        public bool LegyoziE(ISzuperhos ellenfel)
        {
            if (ellenfel.GetType() == typeof(Bosszuallo))
                return ((Bosszuallo)ellenfel).vanEGyengesege && ellenfel.MekkoraAzEreje() < szuperero;
            else
                return szuperero * 2 > ellenfel.MekkoraAzEreje();
        }

        public double MekkoraAzEreje()
        {
            return szuperero;
        }

        public double Szuperero { 
            get { return szuperero; }
            set { szuperero = value; }
        }
        public bool VanEGyengesege {
            get { return vanEGyengesege; } 
            set { vanEGyengesege = value; }
        }

        public override string ToString()
        {
            return $"Szuperero: {szuperero} {(vanEGyengesege ? "Van" : "Nincs")} gyengesége";
        }

    }
}
