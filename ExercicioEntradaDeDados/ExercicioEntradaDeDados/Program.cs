using System.Globalization;

namespace ExercicioEntradaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo");
            string name = Console.ReadLine();
            
            Console.WriteLine("Quantos quartos tem sua casa? ");
            int numeroQuartos = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Entre com o preço de um produto");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha)");
            string[] v = Console.ReadLine().Split();

            string lastName = v[0];
            int idade = int.Parse(v[1]);
            double altura = double.Parse(v[2],CultureInfo.InvariantCulture);

            Console.WriteLine(name);
            Console.WriteLine(numeroQuartos);
            Console.WriteLine(Convert.ToString(preco.ToString("F2")), CultureInfo.InvariantCulture);
            
            Console.WriteLine(lastName);
            Console.WriteLine(idade);
            Console.WriteLine(Convert.ToString(altura.ToString("F2")), CultureInfo.InvariantCulture);

        }
    }
}