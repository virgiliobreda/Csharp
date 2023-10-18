using System.Globalization;

namespace PrimeirosExerciciosOO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Exercício 1
            //Pessoa p1 = new Pessoa();
            //Pessoa p2 = new Pessoa();

            //Console.WriteLine("Dados da primeira pessoa: ");
            //Console.Write("Nome: ");
            //p1.Nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //p1.Idade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Dados segunda pessoa");
            //Console.Write("Nome: ");
            //p2.Nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //p2.Idade = int.Parse(Console.ReadLine());

            //if (p1.Idade > p2.Idade)
            //{
            //    Console.WriteLine($"Pessoa mais velha: {p1.Nome}");
            //}
            //else
            //{
            //    Console.WriteLine($"Pessoa mais velha: {p2.Nome}");
            //}

            // Exercício 2

            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do Primeiro Funcionário");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados Segundo Funcionário");
            Console.Write("Nome : ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário : ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine($"Salário Médio = {media:F2}", CultureInfo.InvariantCulture);

        }
    }
}