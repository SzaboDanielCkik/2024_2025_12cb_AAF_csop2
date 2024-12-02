using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_21_OroklodesPelda2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ososztaly s = new Ososztaly(4, 5);
            //s.x = 23; HIBA
            //s.y = 12; HIBA
            Console.WriteLine(s.X);

            Console.WriteLine(s.ToString());

            Utodosztaly u = new Utodosztaly(123,21,-56);
            u.OrokoltErtekek();
            Console.WriteLine(u.ToString());

            //polimorfizmus - többalakúság
            Ososztaly us = new Utodosztaly(1, 2, 3);
            if(us.GetType() == typeof(Utodosztaly))
                ((Utodosztaly)us).OrokoltErtekek();

            Ososztaly us2 = new Utodosztaly2(45);
            if(us2.GetType() == typeof(Utodosztaly2))
                ((Utodosztaly2)us2).a = 32;

            Console.WriteLine(us.ToString());

            Console.ReadLine();
        }
    }

    class Ososztaly
    {
        //Adattagok
        protected int x;
        protected int y;

        public int X { get { return x; } }

        //Konstruktor
        public Ososztaly(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //Metódusok
        public void TobbszorozX(int a)
        {
            x *= a;
        }

        public override string ToString()
        {
            return $"x: {x} y: {y} ";
        }
    }

    class Utodosztaly : Ososztaly
    {
        //Adattagok
        public int b;

        //Konstruktor
        //public Utodosztaly() : base(12,35)
        //public Utodosztaly(int ujx) : base(ujx,35)
        //public Utodosztaly(int ujx, int ujy) : base(ujx,ujy)
        public Utodosztaly(int ujx, int ujy, int b) : base(ujx, ujy)
        {
            this.b = b;
        }

        //Metódusok
        public void OrokoltErtekek()
        {
            Console.WriteLine($"x: {x} y:{y}");
        }

        public override string ToString()
        {
            //return $"b: {b} {base.ToString()}";
            return $"b: {b} "+ base.ToString();
        }

    }

    class Utodosztaly2 : Ososztaly
    {
        public int a;
        //Konstruktor
        public Utodosztaly2(int a) : base(10,12)
        {
            this.a = a; 
        }
        //Metódusok
        public override string ToString()
        {
            return $"a: {a}"+base.ToString();
        }
    }

}
