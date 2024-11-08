using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_04_HaromszogOsztaly
{
    internal class Haromszog
    {
        //Mezők
        private double a, b, c;

        //Konstruktor
        public Haromszog(double oldal1, double oldal2, double oldal3) {
            a = oldal1;
            b = oldal2;
            c = oldal3;
        }


        public Haromszog(string sor)
        {
            string[] st = sor.Split(';');
            a = Convert.ToDouble(st[0]);
            b = Convert.ToDouble(st[1]);
            c = Convert.ToDouble(st[2]);
        }

        //Metódusok
        public double A
        {
            get { return a; }
        }
        public double B
        {
            get { return b; }
        }
        public double C
        {
            get { return c; }
        }

        //public double A {
        //    get;
        //    private set;
        //}

        public bool SzerkeszthetoE()
        {
            // 5 2 1

            //if (a + b > c && a + c > b && b + c > a)
            //    return true;
            //else
            //    return false;
            return a + b > c && a + c > b && b + c > a;
        }

        public bool EgyeneloszaruE()
        {
            return a == b || a == c || b == c;
        }
        public bool SzabolyosE()
        {
            return a == b && a == c && b == c;
        }
        public bool DerekszoguE()
        {
            return a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a;
        }
        public double Kerulet()
        {
            return a + b + c;
        }
        public double Terulet()
        {
            double s = Kerulet()/2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

    }
}
