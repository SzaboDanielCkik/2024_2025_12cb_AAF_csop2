using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_01_10_Valasztasok
{
    internal class Kepviselo
    {
        public int Sorszam { get; set; }
        public int Szavazat { get; set; }
        public string Vezeteknev { get; set; }
        public string Keresztnev { get; set; }
        public string Part { get; set; }

        public Kepviselo(string sor)
        {
            string[] st = sor.Split(' ');
            Sorszam = Convert.ToInt32(st[0]);
            Szavazat = Convert.ToInt32(st[1]);
            Vezeteknev = st[2];
            Keresztnev = st[3];
            Part = st[4];
        }


    }
}
