using System;
using System.Globalization;

namespace ExercicioFixacao1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string produto1 = "Computadpr";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;


            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é R$ {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é R$ {preco2}");
            Console.WriteLine();
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero {genero}");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arrendondado (três casas decimais): {medida:F3}");
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");

        }
    }
}