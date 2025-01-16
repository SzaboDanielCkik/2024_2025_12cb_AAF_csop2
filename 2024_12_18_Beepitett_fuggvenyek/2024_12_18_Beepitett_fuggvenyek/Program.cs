using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_18_Beepitett_fuggvenyek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SzamosBeepitettFuggvenyek();
            SzovegesBeepitettFuggvenyek();

            Console.ReadLine();
        }

        private static void SzovegesBeepitettFuggvenyek()
        {
            string sz = "  \t\n\n  Géza   kék ,,= az ég. \n\n ";
            Console.WriteLine(sz);
            /*
                Length
                IndexOf('c')
                Split(' ')
                Contains("szov")
                Remove('c')
             */
            //Trim - A szövegről leszedi a whiteSpace karaktereket
            sz = sz.Trim();
            Console.WriteLine(sz.Trim());

            //ToUpper(), ToLower() - Nagybetűssé, kisbetűssé alakít
            Console.WriteLine(sz.ToUpper());

            //Substring(mettől, mennyit) - Kiveszi a szövegből az indexszel és mennyiséggel megadott karaktereket.
            Console.WriteLine(sz.Substring(2,4));

            //Padleft - a megadott karakter számba beleteszi a szöveget, előtte szóközökkel egészíti ki.
            string a = "5";
            Console.WriteLine(a.PadLeft(5));

            //Replace - Megadott szövegre cseréli a kért szövegrészt
            sz = sz.Replace(",", "").Replace("=", "").Replace("  ", " ");
            Console.WriteLine(sz);

            //ToCharArray() - A szövegből karaktertömböt készít
            char[] ct = sz.ToCharArray();
            ct[0] = 'g';
            Console.WriteLine(ct);

            string[] szamokSzoveg = new string[] { "1", "2", "3", "4" };
            int[] szamok = Array.ConvertAll(szamokSzoveg, Convert.ToInt32);
        }

        private static void SzamosBeepitettFuggvenyek()
        {
            List<int> egeszek = new List<int>() {
            2,82,23,90,0,27,65,24,89 };

            /*Kiiratás - foreach*/
            foreach (int a in egeszek) Console.Write(a + " ");
            Console.WriteLine();

            /*Sum - Összegzés*/
            int sum = egeszek.Sum();
            Console.WriteLine("Összeg: "+sum);

            /*Average - Átlag*/
            double avg = egeszek.Average();
            Console.WriteLine("Átlag: "+avg);

            /*Min - Minimum*/
            int min = egeszek.Min();
            Console.WriteLine("Minumum érték: " + min);

            /*Max - Maximum*/
            int max = egeszek.Max();
            Console.WriteLine("Maximum érték: "+ max);

            /*IndexOf - megadja az indexét a keresett elemnek
              Ha van benne az index értékével tér vissza,
              különben -1;
             */
            int szam = 89;
            int index = egeszek.IndexOf(szam);
            Console.WriteLine($"Keresett elem: {szam} indexe: " +
                $"{(index == -1 ? "Nincs benne" : ""+index)}");

            /*Contains - Benne van-e a szerkezetben a keresett elem.*/
            bool vane = egeszek.Contains(szam);
            Console.WriteLine($"{(vane ? "Benne van a":"Nincs benne a")} {szam}");

            /*Remove - törli az első elemet, amit megadunk és visszatér a törlés ereményével.*/
            if (egeszek.Remove(szam))
            {
                foreach (int a in egeszek) Console.Write(a + " ");
                Console.WriteLine();
            }
            else Console.WriteLine($"Nincs a listában a törlendő elem ({szam})");

            /*RemoveAt - index alapján törli az elemet*/
            egeszek.RemoveAt(0);
            foreach (int a in egeszek) Console.Write(a + " ");
            Console.WriteLine();

            /*Sort - Reverse - rendezés*/
            egeszek.Sort();
            foreach (int a in egeszek) Console.Write(a + " ");
            Console.WriteLine();

            egeszek.Reverse();
            foreach (int a in egeszek) Console.Write(a + " ");
            Console.WriteLine();

            Console.WriteLine("Első elem: " + egeszek.First());
            Console.WriteLine("Utolsó elem: " + egeszek.Last());

            //Insert - Elem hozzáadása megadott indexre
            egeszek.Insert(1, 2);
            foreach (int a in egeszek) Console.Write(a + " ");
            Console.WriteLine();

            //InsertRange - Listához lista fűzése
            List<int> ujlista = new List<int>() { 1, 2, 3 };
            ujlista.InsertRange(3,egeszek);
            foreach (int a in ujlista) Console.Write(a + " ");
            Console.WriteLine();


        }
    }
}
