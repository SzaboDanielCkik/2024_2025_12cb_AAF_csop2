using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_25_MegoldasDoga2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount b1 = new BankAccount("Kis Pista", "112233445566", 123.478);
            Console.WriteLine(b1.ToString());
            BankAccount b2 = new BankAccount("Nagy Rozália");
            Console.WriteLine(b2.ToString());
            Console.WriteLine();

            Random r = new Random();
            b1.Deposit(r.NextDouble() * 990 + 10);
            b2.Deposit(r.NextDouble() * 990 + 10);
            Console.WriteLine(b1.ToString());
            Console.WriteLine(b2.ToString());
            Console.WriteLine();


            b1.Withdraw(500);
            b2.Withdraw(500);
            Console.WriteLine(b1.ToString());
            Console.WriteLine(b2.ToString());
            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
