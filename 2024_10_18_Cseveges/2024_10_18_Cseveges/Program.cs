using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_10_18_Cseveges
{
    internal class Program
    {
        static List<Beszelgetes> beszelgetesek = new List<Beszelgetes>();
        static void Main(string[] args)
        {
            Fajlbeolvasas();
            //Console.WriteLine(beszelgetesek[0].Idopont(beszelgetesek[0].kezdet));
            Feladat5();
            Console.ReadLine();
        }

        private static void Feladat5()
        {
            //int index = LeghosszabbBeszelgetesIndexe();
            Beszelgetes max = LeghosszabbBeszelgetes();
            Console.WriteLine(max.kezdemenyezo+" "+max.fogado+ " "+ Kulonbseg(max.Idopont(max.veg), max.Idopont(max.kezdet)));
        }

        private static Beszelgetes LeghosszabbBeszelgetes()
        {
            int maxi = 0;
            for (int i = 0; i < beszelgetesek.Count; i++)
            {
                Beszelgetes b = beszelgetesek[i];
                Beszelgetes c = beszelgetesek[maxi];
                if (Kulonbseg(b.Idopont(b.veg), b.Idopont(b.kezdet)) >
                    Kulonbseg(c.Idopont(c.veg), c.Idopont(c.kezdet)))
                    maxi = i;
            }
            return beszelgetesek[maxi];
        }

        public static int Kulonbseg(List<int> t1, List<int> t2) {
            return Masodpercreszamol(t1) - Masodpercreszamol(t2);
        }

        public static int Masodpercreszamol(List<int> t)
        {
            int sec = t[t.Count - 1] + t[t.Count - 2] * 60 + t[t.Count - 3] * 3600 + t[t.Count - 4] * 3600 * 24;
            return sec;
        }

        private static void Fajlbeolvasas()
        {
            StreamReader f = new StreamReader("csevegesek.txt");
            f.ReadLine();
            while (!f.EndOfStream)
                beszelgetesek.Add(new Beszelgetes(f.ReadLine()));
            f.Close();
        }
    }

    struct Beszelgetes
    {
        public string kezdet, veg, kezdemenyezo, fogado;

        public Beszelgetes(string sor)
        {
            string[] st = sor.Split(';');
            kezdet = st[0];
            veg = st[1];
            kezdemenyezo = st[2];
            fogado = st[3];
        }



        public List<int> Idopont(string szoveg)
        {
            List<int> idopont = new List<int>();
            //string[] st = szoveg.Split('-');
            //string[] datum = st[0].Split('.');
            //string[] ido = st[1].Split(':');
            //for (int i = 0; i < datum.Length; i++)
            //    idopont.Add(Convert.ToInt32(datum[i]));
            //for (int i = 0; i < ido.Length; i++)
            //    idopont.Add(Convert.ToInt32(ido[i]));
            //for (int i = 0; i < szoveg.Length; i+=3)
            //{
            //    string szam = "" + szoveg[i] + szoveg[i + 1];
            //    idopont.Add(Convert.ToInt32(szam));
            //}
            //string[] st = szoveg.Split('.', '-', ':');
            //for (int i = 0; i < st.Length; i++)
            //    idopont.Add(Convert.ToInt32(st[i]));

            idopont = Array.ConvertAll(szoveg.Split('.', '-', ':'), Convert.ToInt32).ToList();

            return idopont;
        }
    }
}
