using System.Globalization;

namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());

            //double[] vect = new double[n];

            //double soma = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    soma += vect[i];
            //}

            //double media = soma / n;
            //Console.WriteLine("AVERAGE HEIGHT = " + media.ToString("F2", CultureInfo.InvariantCulture));



            int n = int.Parse(Console.ReadLine());

            Products[] vect = new Products[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Products { Name = name, Price = price };
            }

            double soma = 0;

            for (int i = 0;i < n;i++)
            {
                soma += vect[i].Price;
            }

            double media = soma / n;


            Console.WriteLine("AVERAGE = " + media.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}