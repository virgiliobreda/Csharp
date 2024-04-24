Console.WriteLine("## Instrução While ##");

//Console.Write("\nDigite um número: ");
//var n = Convert.ToInt32(Console.ReadLine());
//var i = 1;
//if (n > 0)
//{
//    while(i <= 10)
//    {
//        Console.WriteLine($"{n} x {i} = {i*n}");
//        i++;
//    }
//}
//else
//{
//    Console.WriteLine("\nNúmero deve ser maior do que 0");
//}

//Console.WriteLine("\nFim de processamento...");

//while (true)
//{
//    Console.Write("\nInforme um número inteiro: (Para sair digite 999) ");
//    int n = Convert.ToInt32(Console.ReadLine());

//    if (n == 999)
//    {
//        break;
//    }
//    if (n % 2 == 0)
//    {
//        Console.WriteLine($"\n{n} é PAR");
//    }
//    else
//    {
//        Console.WriteLine($"\n{n} é IMPAR");
//    }
//}

int x = 0;
while (x < 5)
{
    int y = 0;
    while (y < 5)
    {
        Console.Write($"({x},{y}) ");
        y++;
    }
    x++;
    Console.WriteLine();
}

Console.WriteLine("\nFim de processamento...");

Console.ReadKey();