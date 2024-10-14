using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_10_04_structVSclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Astruct st = new Astruct(23);
            Aclass cl = new Aclass(24);

            Console.WriteLine(st.ToString());
            Console.WriteLine(cl.ToString());
            Console.WriteLine();

            Nullaz(st);
            Nullaz(cl);

            Console.WriteLine(st.ToString());
            Console.WriteLine(cl.ToString());

            Nullaz(ref st);
            Nullaz(cl);

            Console.WriteLine(st.ToString());
            Console.WriteLine(cl.ToString());

            Console.ReadLine();
        }

        static void Nullaz(Astruct v)
        {
            v.a = 0;
        }

        static void Nullaz(ref Astruct v)
        {
            v.a = 0;
        }

        static void Nullaz(Aclass v)
        {
            v.a = 0;
        }

    }



    struct Astruct
    {
        public int a;

        public Astruct(int a)
        {
            this.a = a;
        }
        public override string ToString()
        {
            return "Struct szám: "+a;
        }
    }

    class Aclass
    {
        public int a=45;

        public Aclass(int a)
        {
            this.a = a;
        }
        public override string ToString()
        {
            return "Class szám: " + a;
        }
    }

}
