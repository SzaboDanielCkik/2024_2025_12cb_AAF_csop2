using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_09_19_Gyakorlas
{
    internal class Program
    {
        static List<string> nevek = new List<string>() {
            "Farkas Máté",
            "Deák Zsombor",
            "Kakuk Ákos",
            "Kis Levente",
            "Varga Csaba",
            "Pálinkás Zoltán",
            "Détári Viktória",
            "Gebhardt Lilla",
            "Sebella Máté",
            "Zsidákovits Bálint",
            "Szabó Dániel"
        };

        static List<Diak> diakok = new List<Diak>();

        static void Main(string[] args)
        {
            /* Hozzon létre egy struktúrát, amiben eltárolja a csoport neveit és mindenknek generál egy 18 számjegyből álló kódot! Ezektet a példányosítás során, adja is át!
             * A struktúrában legyenek a további mezők is:
             * Magasság, szemuveges, azonosító, jelszó.
             * A példányosítás során fusson le egy véletlen generálás, ami megadja a magasságot [160,190] között. Illetve véletlen szerűen állítsa be, hogy szemüveges-e az illető.
             * Majd ugyen itt a példány elkészülése során, fusson le a struktúrában elkészített két függvény, az egyik eredménye az azonosító a másik a jelszó!
             * Azonosító: minden páratlanadik karakter kis betűvel, szóköz nélkül! és a kód számjegyeinek összege!
             * Jelszó: A kód kettesével vett értékének asci kódjából előállított betű! Ha 32-nél kisebb az érték, adjon hozzá 50-et!
             * CSináljon ToString metódust!*/


            
            Console.ReadLine();
        }
    }

    struct Diak {
        //Mezők
        public string nev, kod,id, jelszo;
        public int magassag;
        public bool szemuveg;

        //konstruktor
        public Diak(string nev, string kod) : this()
        {
            Random r = new Random();
            this.nev = nev;
            magassag = r.Next(160,191);
            //if(r.Next(2)==0)
            //    szemuveg = true;
            //else 
            //    szemuveg = false;
            szemuveg = r.Next(2) == 0;
            this.kod = kod;
            id = IdGeneralas(nev);
            jelszo = JelszoGeneralas();
        }

        private string IdGeneralas(string szoveg)
        {
            // Kis Pista -> KisPista -> Ksit -> ksit
            // 123456789123456789 ->90
            // ksit90 
            string szokoznelkuli = Szokoztelenites(szoveg.ToLower());
            string paratlanadikBetuk = Rovidites(szokoznelkuli);
            int szamjegyekOsszege = SzamjegyekOsszeadasa(kod);
            return paratlanadikBetuk + szamjegyekOsszege;
        }

        private int SzamjegyekOsszeadasa(string sz) {
            int osszeg = 0;

            for (int i = 0; i < sz.Length; i++)
            {
                //osszeg += sz[i]-48;
                //osszeg += Convert.ToInt32(sz[i].ToString());
                osszeg += Convert.ToInt32("" + sz[i]);
                //10 => 1+0 = 1
                //1+0 => 48+49 = 97
            }
            return osszeg;
        }

        private string Rovidites(string sz)
        {
            string ki = "";
            for (int i = 0; i < sz.Length; i+=2)
            {
                ki += sz[i];
            }
            return ki;
        }

        private string Szokoztelenites(string sz)
        {
            string ki = "";
            for (int i = 0; i < sz.Length; i++)
            {
                if (sz[i]!=' ') ki += sz[i];
            }
            return ki;
        }

        private string JelszoGeneralas()
        {
            //12 34 56 78 91 23 45 67 89 -> 72H 34. 56? 78L stb.
            //H.?LDob9-i

            string jelszo = "";
            for (int i = 0; i < kod.Length; i+=2)
            {
                int a = Convert.ToInt32("" + kod[i] + kod[i + 1]);
                //jelszo += Convert.ToChar(a);
                jelszo += (char)a;
            }
            return jelszo;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5}", nev, kod,magassag, szemuveg, id,jelszo);
        }
    }
}
