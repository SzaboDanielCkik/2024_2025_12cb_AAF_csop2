using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_02_Pekseg
{
    internal class Pekseg
    {
        public static List<IArlap> termekek = new List<IArlap>();

        public static void Vasarlok(string path)
        {
            StreamReader sr = new StreamReader(path);

            while (!sr.EndOfStream)
            {
                string[] st = sr.ReadLine().Split(' ');
                if (st[0] == "pogacsa")
                {
                    Pogacsa p = new Pogacsa(Convert.ToDouble(st[1]), Convert.ToDouble(st[2]));
                    termekek.Add(p);
                }
                else
                {
                    Kave kv = new Kave(st[1] == "habos");
                    termekek.Add(kv);
                }
            }

            sr.Close();
        }

        public static void EtelLeltar()
        {
            StreamWriter sw = new StreamWriter("leltar.txt");

            for (int i = 0; i < termekek.Count; i++)
            {
                if (termekek[i].GetType() == typeof(Pogacsa))
                    sw.WriteLine(termekek[i].ToString());
            }

            sw.Close();
        }

    }
}
