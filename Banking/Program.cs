using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start:");

            //declaring the account
            Account a1, a2;

            a1 = new Account("Shane (A1)", 100);
            a2 = new Account("Jacob (A2)", 200);
            //using show method
            a1.show();
            //depositing 500 into account one (Shane)
            a1.deposit(500);


            //putting output in main because the only method that can output is show (look at assignment)


            //deposit output
            Console.WriteLine("Depositing money...");
            Console.WriteLine("Success, new status:");
            a1.show();




            //withdraw output
            a1.withdraw(50);
 
            a1.show();

            //transfering money from account one to account two
            Console.WriteLine("Creating second account...");
            a2.show();
            
            a1.transferA1(50, a1, a2);
            a2.show();
            a1.show();
        }

    }
}
