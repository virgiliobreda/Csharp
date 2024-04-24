Console.WriteLine("## Estrutura For ##");

Console.Write("Digite um número inteiro: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{n} x {i} = {n * i}");
}

Console.ReadKey();

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write($"({i},{j}) ");
    }
    Console.WriteLine();
}

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
       for (int k = 0; k < 5; k++)
        {
            Console.Write($"({i},{j},{k}) ");
        }
    }
    Console.WriteLine();
}