using CustomExceptionAccount.Entties;
using CustomExceptionAccount.Entties.Exceptions;
using System.Globalization;

namespace CustomExceptionAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the account data: ");
                Console.Write("Number: ");
                int numberAccount = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double inicialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                Account account = new Account(numberAccount, holder, inicialBalance, withdrawLimit);

                Console.Write("Enter amouth for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(withdraw);

                Console.WriteLine();
                Console.Write($"New balance: {account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            catch (DomainException ex) 
            {
                Console.WriteLine($"Withdraw error: {ex.Message}");
            }

            catch (FormatException ex)
            {
                Console.WriteLine($"Format error: {ex.Message}");
            }

            catch (Exception ex) 
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}