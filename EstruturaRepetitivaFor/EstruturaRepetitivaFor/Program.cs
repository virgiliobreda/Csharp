namespace EstruturaRepetitivaFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;
            int valor = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.Write($"Valor #{i}: ");
                valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine($"SOMA = {soma}");
        }
    }
}