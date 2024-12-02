using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_25_MegoldasDoga2
{
    internal class BankAccount
    {
        //Adattagok
        private string accountHolder, accountNumber;
        private double balance;

        private static int accountCount;


        //Konstruktor
        public BankAccount(string accountHolder, string accountNumber, double balance) {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = balance;
            accountCount++;
        }
        public BankAccount(string accountHolder)
        {
            this.accountHolder = accountHolder;
            accountNumber = "";
            balance = 0;
            accountCount++;
        }

        //Metódusok
        public string AccountHolder {
            get { return accountHolder; }
            private set { accountHolder = value; }
        }
        public string AccountNumber
        {
            get { return accountNumber; }
            private set { accountNumber = value; }
        }
        public double Balance {
            get { return balance; }
            private set { balance = value; }
        }

        public static int GetAccountCount()
        {
            return accountCount;
        }

        public void Deposit(double osszeg)
        {
            balance += osszeg;
        }

        public void Withdraw(double osszeg) {
            if (balance >= osszeg)
                balance -= osszeg;
        }

        public override string ToString()
        {
            return $"[{accountCount}] {accountHolder} {balance} {accountNumber}";
        }

    }
}
