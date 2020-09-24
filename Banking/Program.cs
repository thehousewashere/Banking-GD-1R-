using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Accessing first account:");
            Console.ForegroundColor = ConsoleColor.Gray;

            //declaring the account
            Account a1, a2;

            a1 = new Account("Shane (A1)", 100);
            a2 = new Account("Jacob (A2)", 200);
            //using show method
            a1.show();
            //depositing money into account one (Shane)
            a1.deposit(500);


            //putting output in main because the only method that can output is show (look at assignment)


            //deposit output
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("|Depositing  $500 for Shane (A1)");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("|UPDATED: ");
            a1.show();




            //withdraw output
            if (a1.withdraw(500) == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("|Withdrawing $500 for Shane (A1)");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.WriteLine("|Withdraw canceled: Insufficient funds.");
            }




            Console.Write("|UPDATED: ");
            a1.show();

            //transfering money from account one to account two
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Accessing second account:");
            Console.ForegroundColor = ConsoleColor.Gray;
            a2.show();


            Console.WriteLine("Transferring $50 from Jacob (A2) to Shane (A1).");
            if (a1.transferA1(50, a1, a2) == true)
            { }
            else
            {
                Console.WriteLine("|Transfer canceled: Insufficient funds.");
            }
            Console.Write("|UPDATED: ");
            a2.show();
            Console.Write("|UPDATED: ");
            a1.show();
        }

    }
}
