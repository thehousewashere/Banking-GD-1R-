using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class Account
    {
        private string NameOne = "name";
        private int BalOne = 0;
        public Account()
        {
            NameOne = "name";
            BalOne = 0;

        }
        public Account(string NameOne, int BalOne)
        {
            this.NameOne = NameOne;
            this.BalOne = BalOne;
        }

        //shows the account name and amount
        public void show()
        {
            Console.WriteLine("User: " + NameOne + ", Balance: $" + BalOne);
        }

        //puts the deposit into the account and displays the account value
        public void deposit(int DepoAmount)
        {
            //DepoAmount = 100;
            BalOne = BalOne + DepoAmount;
        }

        //
        public bool withdraw(int WithAmount)
        {
            if (BalOne - WithAmount >= 0)
            {
                BalOne = BalOne - WithAmount;
                Console.WriteLine("Withdrawing money...");
                Console.WriteLine("Success, new status: ");
                return true;
            }
            else
            {
                Console.WriteLine("Withdrawing money...");
                Console.WriteLine("Insufficient funds, current status: ");
                return false;
            }
        }
        public bool transferA2(int amount, Account a2, Account a1)
        {
            Console.WriteLine("Transferring $" +amount+" from " + a2.NameOne + " to " + a1.NameOne + ".");
            a2.deposit(amount);
            a1.withdraw(amount);
            return true;
        }
        public bool transferA1(int amount, Account a1, Account a2)
        {
            Console.WriteLine("Transferring $" + amount + " from " + a1.NameOne + " to " + a2.NameOne + ".");
            a1.deposit(amount);
            a2.withdraw(amount);
            return true;
        }
    }
}

