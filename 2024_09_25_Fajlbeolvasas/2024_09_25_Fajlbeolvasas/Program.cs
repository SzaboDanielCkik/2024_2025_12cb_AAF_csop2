using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2024_09_25_Fajlbeolvasas
{
    internal class Program
    {
        static List<Kepviselo> kepviselok = new List<Kepviselo>();

        static void Main(string[] args)
        {
            Fajlbeolvasas();
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();

            Console.ReadLine();
        }

        static void Feladat5()
        {
            List<string> partok = PartokListaja();
            int osszesSzavazat = OsszSzavazat();
            for (int i = 0; i < partok.Count; i++) {
                int partSzavazat = PartSzavazata(partok[i]);
                Console.WriteLine("{0}= {1}%", partok[i], Math.Round((double)partSzavazat/osszesSzavazat*100,2));
            }
        }

        static int PartSzavazata(string part)
        {
            int sum = 0;
            for (int i = 0; i < kepviselok.Count; i++)
                if(kepviselok[i].part == part)
                    sum += kepviselok[i].szavazat;
            return sum;
        }

        static List<string> PartokListaja()
        {
            List<string> partok = new List<string>();
            for (int i = 0; i < kepviselok.Count; i++) {
                if (!BenneVanePart(partok, kepviselok[i].part))
                    partok.Add(kepviselok[i].part);
            }
            return partok;
        }

        static bool BenneVanePart(List<string> lista, string sz)
        {
            //int i = 0;
            //while(i <lista.Count && lista[i] != sz)
            //    i++;
            //return i < lista.Count;

            return lista.Contains(sz);
        }


        static void Feladat4()
        {
            int osszes = OsszSzavazat();
            Console.WriteLine("A választáson {0} állampolgár, a jogosultak {1}%-a vett részt.",osszes , Math.Round((double)osszes/12345*100,2));
        }

        static int OsszSzavazat()
        {
            int osszeg = 0;
            for (int i = 0; i < kepviselok.Count; i++)
                osszeg += kepviselok[i].szavazat;
            return osszeg;
        }

        private static void Feladat3()
        {
            (string vnev, string knev) = NevBekeres();
            int index = BenneVaneIndex(vnev, knev);
            if (index > -1)
            {
                int szavazat = kepviselok[index].szavazat;
                Console.WriteLine("{0} db szavazatot kapott a megadott képviselő.", szavazat);
            }
            else
                Console.WriteLine("Ilyen nevű képviselőjelölt nem szerepel a nyilvántartásban!");
        }

        

        static int BenneVaneIndex(string vnev, string knev)
        {
            int i = 0;
            while (i < kepviselok.Count && !(kepviselok[i].vnev == vnev && kepviselok[i].knev == knev))
                i++;
            //if (i < kepviselok.Count)
            //    return i;
            //else 
            //    return -1;
            return i < kepviselok.Count ? i : -1;
        }

        static (string, string) NevBekeres()
        {
            Console.Write("Adja meg a keresett képviselő vezetéknevét:  ");
            string vnev = Console.ReadLine();
            Console.Write("Adja meg a keresett képviselő keresztknevét:  ");
            string knev = Console.ReadLine();
            return (vnev, knev);
        }

        static void Feladat2()
        {
            Console.WriteLine("A helyhatósági választáson {0} jelölt indult.",kepviselok.Count);
        }

        static void Fajlbeolvasas()
        {
            //string[] sorok = File.ReadAllLines("szavazatok.txt");
            StreamReader f = new StreamReader("szavazatok.txt");

            while (!f.EndOfStream)
            {
                //f.ReadLine(); //egy sort kiolvas

                //string[] st = f.ReadLine().Split(' ');
                //Kepviselo sv = new Kepviselo(Convert.ToInt32(st[0]), Convert.ToInt32(st[1]), st[2], st[3], st[4]);
                
                //Kepviselo sv = new Kepviselo(f.ReadLine());
                //kepviselok.Add(sv);

                kepviselok.Add(new Kepviselo(f.ReadLine()));

            }

            f.Close();
        }
    }

    struct Kepviselo
    {
        public string vnev, knev, part;
        public int kerulet, szavazat;

        public Kepviselo(int kerulet, int szavazat, string vnev, string knev, string part)
        { 
            this.kerulet = kerulet;
            this.szavazat = szavazat;
            this.vnev = vnev; 
            this.knev = knev;
            this.part = part;
        }

        public Kepviselo(string sor)
        {
            string[] st = sor.Split(' ');
            kerulet = Convert.ToInt32(st[0]);
            szavazat= Convert.ToInt32(st[1]);
            vnev = st[2];
            knev = st[3];
            part = st[4];
        }

        public override string ToString()
        {
            //if(part == "-")
            //    return $"{kerulet} {szavazat} {vnev} {knev} függelten";
            //else
            //    return $"{kerulet} {szavazat} {vnev} {knev} {part}";
            return string.Format("{0} {1} {2} {3} {4}",kerulet, szavazat, vnev, knev, part == "-" ? "független" : part);
        }
    }
}
