using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_12_Gepjarmu
{
    internal class Orszagut
    {
        public static List<Jarmu> jarmuvek = new List<Jarmu>();

        public static void JarmuvekJonnek(string path)
        {
            StreamReader sr = new StreamReader(path);

            while (!sr.EndOfStream)
            {
                string[] st = sr.ReadLine().Split(';');
                if (st[0] == "robogo")
                {
                    Robogo robogo = new Robogo(Convert.ToInt32(st[3]), Convert.ToInt32(st[2]), st[1]);
                    jarmuvek.Add(robogo);
                }
                else if (st[0] == "audi")
                {
                    AudiS8 audi = new AudiS8(st[3] == "true", Convert.ToInt32(st[2]), st[1]);
                    jarmuvek.Add(audi);
                }                    
            }

            sr.Close();
        }

        public static void KiketMertunkBe()
        {
            StreamWriter sw = new StreamWriter("buntetes.txt");
            for (int i = 0; i < jarmuvek.Count; i++)
            {
                sw.Write(jarmuvek[i]);
                if (jarmuvek[i].GetType() == typeof(AudiS8))
                {
                    if (jarmuvek[i].GyorshajtottE(90))
                        sw.WriteLine(" gyorshajtott");
                    else
                        sw.WriteLine();
                }
                else if (jarmuvek[i].GetType() == typeof(Robogo))
                {
                    if (!((Robogo)jarmuvek[i]).HaladhatItt(90))
                        sw.WriteLine(" Nem haladhat itt.");
                    else
                        sw.WriteLine();
                }
            }
            sw.Close();
        }
    }
}
