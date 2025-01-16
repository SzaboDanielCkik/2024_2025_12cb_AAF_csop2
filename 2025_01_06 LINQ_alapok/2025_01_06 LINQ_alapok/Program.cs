using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_01_06_LINQ_alapok
{
    internal class Program
    {
		static List<BankAccount> customers;
        static List<int> egeszek = new List<int>();
        static void Main(string[] args)
        {
            AdatokLetrehozasa();

            //LINQEgyszeruPelda();
            //LINQObjektumPelda();

            //LINQEgyszeruPeldaEgyediElemek();
            //LINQObjektumPeldaEgyediElemek();

            //LinqAgregatumOperatorok();
            //LinqOrderBy();

            //LinqEldontes();
            //LinqSequenceEqual();

            LinqFind();

            Console.ReadLine();
        }

        private static void LinqFind()
        {
            /*Vissza adja az első olyan elemet, ami rendelkezik a megadott tulajdonsággal.*/

            //Melyik az első elem, ahol a szlaszámban van 9-es
            var objektum = customers.Find(x => x.AccountNumber.Contains('x'));
            Console.WriteLine(objektum);
        }

        private static void LinqSequenceEqual()
        {
            var a = customers.OrderBy(x => x.Name);
            var b = customers.OrderBy(x => x.Name);
            Console.WriteLine(a.SequenceEqual(b));
        }

        private static void LinqEldontes()
        {
            //Van-e olyan, hogy ....
            //bool vaneNegativ = customers.Any(x => x.Balance < 0);
            //Console.WriteLine("van-e negatív egyenleg: "+vaneNegativ);
            //Mindegyik elemre igaz-e, az hogy ....
            bool pozitiv = customers.All(x => x.Balance >= 0);
            Console.WriteLine("Az összes egyenleg pozitív: " + pozitiv);
        }

        private static void LinqOrderBy()
        {
            var orderedDatas = customers.OrderByDescending(x=>x.Balance).ThenByDescending(x=>x.Name);

            foreach (var elem in orderedDatas)
            {
                Console.WriteLine(elem + " ");

            }
        }

        private static void LinqAgregatumOperatorok()
        {
            //var result = (from x in customers
            //             select x.Balance).Sum();

            //var result = egeszek.Average();

            //var result = customers.Sum(elem => elem.Balance);
            //var result = customers.Average(elem => elem.Balance);
            //var result = customers.Max(elem => elem.Balance);
            var result = customers.Count(elem => elem.Balance>1000);

            Console.WriteLine(result);

        }

        private static void LINQObjektumPeldaEgyediElemek()
        {
            //customers.Add(customers[0]);
            //customers.Add(customers[0]);
            //customers.Add(customers[0]);
            var szurtElemek = customers.Select(elem=>elem.Name).Distinct();

            foreach (var elem in szurtElemek)
            {
                Console.WriteLine(elem + " ");

            }
        }

        private static void LINQEgyszeruPeldaEgyediElemek()
        {                              
            // Szürjük ki az egészek listából az egyedi elemeket!
            var szurtElemek = egeszek.Distinct();
            //HashSet - Halmaz, ahol nem lehetnek ismétlődő elemek!
            //var szurtElemek = egeszek.ToHashSet();
            //HashSet<int> szurtElemek = new HashSet<int> { 1,1,1,1,1,2,2,2,3,3,6,6,6,5,5};
            foreach (var szam in szurtElemek)
            {
                Console.Write(szam + " ");
            }
        }

        private static void LINQObjektumPelda()
        {
            //var queryResults = from x in customers
            //                   where x.AccountNumber.Length == 11
            //                   select x;

            //var queryResults = customers.Where(x => x.AccountNumber.Length == 11);
            var queryResults = customers
                .Where(x => x.AccountNumber.Length == 11)
                .Select(elem => elem.Name);

            Console.WriteLine();
            foreach (var x in queryResults)
            {
                Console.WriteLine(x + " ");
            }

        }

        private static void LINQEgyszeruPelda()
        {
            //int, string, double, bool ...
            //var queryResults = from szam in egeszek
            //                   where szam > 3
            //                   select szam + "";

            //var queryResults = egeszek.Where(szam => szam > 3);
            //var queryResults = egeszek.Where(szam => szam > 3).Select(szam=>szam+"#d");
            //Lambda kifejezés
            List<int> queryResults = egeszek.Where(szam => szam > 3).ToList();

            foreach (var szam in queryResults)
            {
                Console.Write(szam + " ");
            }

        }


        private static void AdatokLetrehozasa()
        {
            egeszek = new List<int> { 5,6,0,1,2,6,2,9,5,0,3,10,5,9,7,5,4,8,7,6 };
			
			customers = new List<BankAccount>()
            {
                new BankAccount("John Doe", 1000.0, "123-456-789"), //M1
                new BankAccount("Alice Smith", 0.0, "987-654-321"),//M2
                new BankAccount("Robert Johnson", 1000000.0, "555-123-999"),
                new BankAccount("Sarah White", 50.5, "666-777-888"),
                new BankAccount("Superman", 5000.0, "000-000-001"),//M5
                new BankAccount("Superman", 10000.0, "000-000-002"),//M6
                new BankAccount("Bruce Wayne", 0.0, "111-222-333"),
                new BankAccount("Peter Parker", 1200.75, "444-555-666"),
                new BankAccount("Tony Stark", 99999999.99, "1234-5678-9012-3456")
            };
        }
    }
	
	class BankAccount
    {
        public string Name { get; private set; }
        public double Balance { get; private set; } //egyenleg
        public string AccountNumber { get; private set; }

        public BankAccount(string name, double balance, string accountNumber)
        {
            Name = name;
            Balance = balance;
            AccountNumber = accountNumber;
        }

        public override string ToString()
        {
            return $"Name: {Name} Balance: {Balance} AccountNumber: {AccountNumber}";
        }
    }
}
