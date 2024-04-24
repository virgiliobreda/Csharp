Console.WriteLine("## Instrução IF ##\n");

Console.Write("O cliente é especial? (true/false): ");
var resposta = Convert.ToBoolean(Console.ReadLine());

if (resposta)
{
    Console.WriteLine("Desconto de 10%\n");
}
Console.WriteLine("Fim do processamento\n");