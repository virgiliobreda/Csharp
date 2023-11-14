using Heranca.Entities;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0);
            BussinesAccount bacc = new BussinesAccount(1002, "Maria", 0, 500);

            // Upcasting

            Account acc1 = bacc;

            Account acc2 = new BussinesAccount(1003, "bob", 0.0, 200);

            Account acc3 = new SavingAccount(1004, "Ana", 0.0, 0.01);

            // Downcasting

            BussinesAccount acc4 = (BussinesAccount)acc2;
            acc4.Loan(100);

            //BussinesAccount acc5 = (BussinesAccount)acc3;

            if (acc3 is BussinesAccount)
            {
                //BussinesAccount acc5 = (BussinesAccount)acc3;

                BussinesAccount acc5 = acc3 as BussinesAccount;
                acc5.Loan(200);
                Console.WriteLine("Loan");
            }

            if (acc3 is SavingAccount)
            {
                //SavingAccount acc5 = (SavingAccount)acc3;

                SavingAccount acc5 = acc3 as SavingAccount;
                
                acc5.UpdateBalance();
                Console.WriteLine("Update");
            }
        }
    }
}