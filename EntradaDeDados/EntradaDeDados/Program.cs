using System.Globalization;

namespace EntradaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] v = Console.ReadLine().Split(' ');
            string nome = v[0];
            char sexo = char.Parse(v[1]);
            int idade = int.Parse(v[2]);
            double altura = double.Parse(v[3], CultureInfo.InvariantCulture);


            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));


            //string? frase = Console.ReadLine();
            //string? x = Console.ReadLine();
            //string? y = Console.ReadLine();
            //string? z = Console.ReadLine();
            //string[] vet = Console.ReadLine().Split(" ");
            //string a = vet[0];
            //string b = vet[1];
            //string c = vet[2];

            //Console.WriteLine("Você digitou ");

            //Console.WriteLine(frase);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

        }
    }
}