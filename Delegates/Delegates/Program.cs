using Delegates.Services;

namespace Delegates
{ delegate double BinaryNumericOperetion(double n1, double n2);
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperetion op = CalculationService.Max;

            double result = op.Invoke(a, b);
            Console.WriteLine(result);

            
        }
    }
}