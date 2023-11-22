using FixingExerciseAbstractMethod.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Globalization;

namespace FixingExerciseAbstractMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayers = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double heathExpenditure = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    taxPayers.Add(new Individual(name, anualIncome, heathExpenditure));
                }
                else if (ch == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberInployeers = int.Parse(Console.ReadLine());

                    taxPayers.Add(new Company(name, anualIncome, numberInployeers));
                }
            }

            Console.WriteLine();
            
            Console.WriteLine("Taxes Paid: ");
            double sum = 0;
            foreach (TaxPayer t in taxPayers)
            {

                Console.WriteLine($"{t.Name}: $ {t.Tax().ToString("F2",CultureInfo.InvariantCulture)}");
                sum += t.Tax();
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {sum}");
        }
    }
}