using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_20_Szuperhosok
{
    internal class Kepregeny
    {
        public static List<IMilliardos> szuperhosok = new List<IMilliardos>();
        public static void Szereplok(string path)
        {
            try
            {
                StreamReader sr = new StreamReader(path);

                while (!sr.EndOfStream)
                {
                    szuperhosok.Add(SzuperhosKeszit(sr.ReadLine()));
                }
                sr.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\nHiba történt a fájlbeovlasás során!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\nHiba történt!");
            }
        }

        private static IMilliardos SzuperhosKeszit(string line)
        {
            string[] st = line.Split(' ');
            IMilliardos sv;
            if (st[0] == "Vasember")
            {
                sv = new Vasember();
            }
            else
            {
                sv = new Batman();
            }
            Kutyukeszites(sv, Convert.ToInt32(st[1]));
            return sv;

        }

        public static void SzereplokKiir()
        {
            foreach (var sv in szuperhosok)
            {
                Console.WriteLine(sv.ToString());
            }
        }

        private static void Kutyukeszites(IMilliardos sv, int v)
        {
            for (int i = 0; i < v; i++)
                sv.KutyutKeszit();
        }
    }
}
