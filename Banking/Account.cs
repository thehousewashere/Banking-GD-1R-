using System;

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

        //puts the deposit into the selected account
        public void deposit(int DepoAmount)
        {

            BalOne = BalOne + DepoAmount;
        }

        //withdraws from the selected account
        public bool withdraw(int WithAmount)
        {
            if (BalOne - WithAmount >= 0)
            {

                BalOne = BalOne - WithAmount;
                return true;
            }
            else
            {
                return false;
            }
        }
        //transfers from A2 to A1 
        public bool transferA2(int amount, Account a2, Account a1)
        {
            if (a2.BalOne - amount >= 0)
            {
                a1.withdraw(amount);
                a2.deposit(amount);
                return true;
            }
            else
            {
                return false;
            }

        }
        //transfers from A1 to A2 
        public bool transferA1(int amount, Account a1, Account a2)
        {
            if (a1.BalOne - amount >= 0)
            {
                a2.withdraw(amount);
                a1.deposit(amount);
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

