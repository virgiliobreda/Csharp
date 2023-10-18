using System.Globalization;

namespace ExercicioRepetitivaFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício 1
            //int x = int.Parse(Console.ReadLine());

            //for (int i = 0; i <= x; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            // Exercício 2

            //int n = int.Parse(Console.ReadLine());

            //int n_in = 0;
            //int n_out = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    int x = int.Parse(Console.ReadLine());
            //    if (x >= 10 && x <= 20)
            //    {
            //        n_in += 1;    
            //    }
            //    else
            //    {
            //        n_out += 1;
            //    }
            //}

            //Console.WriteLine(n_in);
            //Console.WriteLine(n_out);

            // Exercício 3

            //int n = int.Parse(Console.ReadLine());


            //for (int i = 0; i < n; i++)
            //{
            //    string[] valores = Console.ReadLine().Split(' ');
            //    double n1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            //    double n2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            //    double n3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //    double media = (n1 * 2 + n2 * 3 + n3 * 5) / 10;

            //    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

            //}

            // Exercício 4

            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    string[] entrada = Console.ReadLine().Split(" ");

            //    double n1 = double.Parse(entrada[0]);
            //    double n2 = double.Parse(entrada[1]);

            //    if (n2 == 0)
            //    {
            //        Console.WriteLine("Divisao impossivel");
            //    }
            //    else
            //    {
            //        double divisao = n1 / n2;
            //        Console.WriteLine(divisao);
            //    }

            // Exercício 5

            //int n = int.Parse(Console.ReadLine());

            //int fatorial = 1;

            //for (int i = 1; i <= n; i++)
            //{
            //    fatorial *= i;
            //}

            //Console.WriteLine(fatorial);


            // Exercício 6

            ////int n = int.Parse(Console.ReadLine());

            ////for (int i = 1; i <= n; i++)
            ////{
            ////    if (n % i == 0)
            ////    {
            ////        Console.WriteLine(i);
            ////    }
            ////}

            // Exercício 7

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int quadradro = i * i;
                int cubo = i * i * i;

                Console.WriteLine($"{i} {quadradro} {cubo}");
            }
        }
    }
}