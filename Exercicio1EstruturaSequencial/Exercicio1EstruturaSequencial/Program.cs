using System.Globalization;

namespace Exercicio1EstruturaSequencial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Exercício 1

            Console.WriteLine("Digite um número inteiro");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número inteiro");
            int n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;
            Console.WriteLine($"Soma = {soma}");

            // Exercício 2

            Console.WriteLine("Digite o valor do raio");
            double raio = double.Parse(Console.ReadLine());

            double area = 3.14159 * (Math.Pow(raio, 2));

            Console.WriteLine($"Área = {area.ToString("F4")}", CultureInfo.InvariantCulture);

            //Exercício 3

            Console.WriteLine("Digite um número inteiro");
            int nu1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número inteiro");
            int nu2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite mais um número inteiro");
            int nu3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o último número intieiro");
            int nu4 = int.Parse(Console.ReadLine());

            int diferenca = (nu1 * nu2 - nu3 * nu4);
            Console.WriteLine($"A diferença dos valores é {diferenca}");

            // Exercicio 4 

            int numero, horas;
            double valorHora, salario;

            Console.WriteLine("Digite o número do funcionário");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quantas horas o funcionário trabalhou? ");
            horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor por hora?");
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = valorHora * horas;

            Console.WriteLine($"Number = {numero}");
            Console.WriteLine("Salary  U$ = " + salario.ToString("F2"), CultureInfo.InvariantCulture);

            // Exercício 5

            int codigo1, codigo2, quantidade1, quantidade2;
            double valor1, valor2, preco1, preco2, resultado;

            Console.WriteLine("digite o código do produto");
            codigo1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade");
            quantidade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do produto");
            valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            preco1 = quantidade1 * valor1;

            Console.WriteLine("digite o código do produto");
            codigo2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade");
            quantidade2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do produto");
            valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            preco2 = quantidade2 * valor2;

            resultado = preco1 + preco2;

            Console.WriteLine($"VALOR A PAGAR = {resultado:F2}");

            // Exercício 6
            double a, b, c, triangulo, circulo, trapezio, quadrado, retangulo;

            Console.WriteLine("Digite 3 valores");
            string[] valores = Console.ReadLine().Split(' ');

            a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            c = double.Parse(valores[2], CultureInfo.InvariantCulture);


            triangulo = a * c / 2.0;
            circulo = 3.14159 * Math.Pow(c, 2);
            trapezio = (a + b) / 2.0 * c;
            quadrado = b * b;
            retangulo = a * b;


            Console.WriteLine($"Triangulo = {triangulo.ToString("F3")}", CultureInfo.InvariantCulture);
            Console.WriteLine($"Circulo = {circulo.ToString("F3")}", CultureInfo.InvariantCulture);
            Console.WriteLine($"Trapezio = {trapezio.ToString("F3")}", CultureInfo.InvariantCulture);
            Console.WriteLine($"Quadradro = {quadrado.ToString("F3")}", CultureInfo.InvariantCulture);
            Console.WriteLine($"Retangulo = {retangulo.ToString("F3")}", CultureInfo.InvariantCulture);




        }
    }
}