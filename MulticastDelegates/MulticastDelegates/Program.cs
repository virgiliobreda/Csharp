using MulticastDelegates.Services;

namespace MulticastDelegates
{
    internal class Program
    {
        delegate void BinaryNumberOperation(double n1,  double n2);
        static void Main(string[] args)
        {
            BinaryNumberOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;
            

            double a = 10;
            double b = 12;

            op.Invoke(a, b);
        }
    }
}