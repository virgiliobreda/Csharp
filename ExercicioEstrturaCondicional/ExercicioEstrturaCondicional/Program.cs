using System.Globalization;

namespace ExercicioEstrturaCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício 1

            Console.WriteLine("Digite um número inteiro");
            int entrada2 = int.Parse(Console.ReadLine());

            if (entrada2 > 0)
            {
                Console.WriteLine("O número é positivo");
            }
            else
            {
                Console.WriteLine("O número é negativo ");
            }

            // Exercício 2

            Console.WriteLine("Digite um número inteiro");
            int entrada = int.Parse(Console.ReadLine());

            if (entrada % 2 == 0)
            {
                Console.WriteLine("O número é par");
            }
            else
            {
                Console.WriteLine("O número é impar");
            }

            // Exercício 3

            Console.WriteLine("Digite dois números (na mesma linha)");
            string[] valores = Console.ReadLine().Split(" ");

            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("Os números são múltiplos");
            }
            else
            {
                Console.WriteLine("Os números não são múltiplos");
            }

            // Exercicio 4


            string[] valores3 = Console.ReadLine().Split(' ');

            int horaInicial = int.Parse(valores3[0]);
            int horaFinal = int.Parse(valores3[1]);
            int duracao;


            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }

            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine($"O jogo durou {duracao} horas");

            // Exercício 5

            Console.WriteLine("Escreva o código e a quantidade do item:");
            string[] valores2 = Console.ReadLine().Split(" ");

            int codigo = int.Parse(valores2[0]);
            int quantidade = int.Parse(valores2[1]);
            double preco = 0;

            if (codigo == 1) // Cachorro quente
            {
                preco = quantidade * 4.00;
            }
            else if (codigo == 2)  // X salada
            {
                preco = quantidade * 4.50;
            }
            else if (codigo == 3) // X Bacon
            {
                preco = quantidade * 5.0;
            }
            else if (codigo == 4) // Torrada Simples
            {
                preco = quantidade * 2.0;
            }

            else if (codigo == 5) // Refrigerante
            {
                preco = quantidade * 1.50;
            }

            Console.WriteLine($"Total = R$ {preco}");


            // Exercício 6

            Console.WriteLine("Digite um valor para saber o intervalo");
            double entrada1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (entrada1 < 0 || entrada1 > 100)
            {
                Console.WriteLine("Intervalo Fora do alcance");
            }
            else if (entrada1 <= 25)
            {
                Console.WriteLine("Intervalo (0, 25)");
            }
            else if (entrada1 <= 50)
            {
                Console.WriteLine("Intervalo (25, 50)");
            }
            else if (entrada1 <= 75)
            {
                Console.WriteLine("Intervalo (50, 75");
            }
            else
            {
                Console.WriteLine("Intervalo (75, 100)");
            }

            // Exercício 7

            Console.WriteLine("Digite dois valores para representar as cordenadas x e y e descobrir seu quadrante");

            string[] valores1 = Console.ReadLine().Split(' ');

            double x = double.Parse(valores1[0]);
            double y = double.Parse(valores1[1]);

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }

            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }

            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }

            else if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else
            {
                Console.WriteLine("Q4");
            }
            // Exercício 8

            Console.WriteLine("Informe seu salário para saber o valor de imposto que deve pagar:");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto = 0;
            if (salario > 0 && salario <= 2000)
            {
                Console.WriteLine("Isento");
            }
            else if (salario <= 3000)
            {
                imposto = (salario - 2000) * 0.08;

            }
            else if (salario <= 4500)
            {
                imposto = (salario - 3000) * 0.18 + 1000 * 0.08;
            }
            else
            {
                imposto = (salario - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
            }

            Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}