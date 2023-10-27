namespace Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            
            int a = 10;
            int triple;

            calculadora.Triple(a, out triple);
            Console.WriteLine(a);
            Console.WriteLine(triple);
        }
    }
}