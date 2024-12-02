using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_15_Kocsmaszimulator
{
    internal class Ember
    {
        //Adattagok
        private string nev;
        private int kor, penz, reszegseg;
        private bool ferfi, kocsmaban;

        public string Nev{get { return nev; }}
        public int Kor {get { return kor; } }
        public int Reszegseg { get { return reszegseg; } }
        public bool Ferfi { get { return ferfi; } }
        public bool Kocsmaban { get { return kocsmaban; } }
        public int Penz {
            get { return penz; }
            set { penz = value; }
        }
  


        //Konstruktor

        public Ember(string nev, int kor, bool ferfi, int penz)
        {
            this.nev = nev;
            this.kor = kor;
            this.ferfi = ferfi;
            this.penz = penz;
            reszegseg = 0;
            kocsmaban = false;
        }

        //Metódusok
        public void Iszik(Kocsmaros kocsmaros)
        {
            if (kocsmaban)
            {
                penz--;
                reszegseg++;
                Kocsmaros.koszospohar++;
                kocsmaros.Penz++;
            }
            else
                Console.WriteLine("Nincs a kocsmában");

            if (reszegseg == 45)
            {
                Alszik();
            }    
        }

        public void Iszik(Kocsmaros kocsmaros, Ital ital)
        {
            if (kocsmaban)
            {
                penz -= ital.Ar;
                reszegseg += ital.Alkoholtartalom;
                Kocsmaros.koszospohar++;
                kocsmaros.Penz += ital.Ar;
            }
            if (reszegseg == 40)
            {
                Alszik();
            }
        }

        public void Alszik()
        {
            reszegseg = 0;
            Console.WriteLine($"{nev} elaludt!");
        }

        public void Hazamegy()
        {
            kocsmaban = false;
            Console.WriteLine($"{nev} hazament.");
        }

        public void Jon()
        {
            kocsmaban = true;
            Console.WriteLine($"{nev} megérkezett.");
        }

        public override string ToString()
        {
            return $"{nev} ({kor}) - pénz: {penz} - részegség: {reszegseg}";
        }
    }
}
