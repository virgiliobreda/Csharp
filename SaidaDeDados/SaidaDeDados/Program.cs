using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";


            // Placeholder
            Console.WriteLine("{0} tem {1} anos e possui o saldo de {2}", nome, idade, saldo.ToString("F2"));

            // Interpolação
            Console.WriteLine($"{nome} tem {idade} e seu saldo é de {saldo:F2}");

            // Concatenação
            Console.WriteLine(nome + " tem " + idade + " e tem o saldo de " + saldo.ToString("F2", CultureInfo.InvariantCulture));



                

            //Console.WriteLine(genero);
            //Console.WriteLine(idade);
            //Console.WriteLine(saldo.ToString("F2"));
            //Console.WriteLine(nome);
            //Console.WriteLine(saldo.ToString("F4"));
            //Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}