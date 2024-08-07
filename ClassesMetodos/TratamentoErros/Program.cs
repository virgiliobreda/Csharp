Console.WriteLine("Divisão números inteiros");
Console.WriteLine("x / y");
try
{
    Console.Write("\nInforme o valor de x: ");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.Write("\nInforme o valor de y: ");
    int y = Convert.ToInt32(Console.ReadLine());

    var z = x / y;
    Console.WriteLine($"{x} / {y} = {z}");
}
catch (Exception ex)
{
    Console.WriteLine($"\nErro {ex.Message?.ToString()}");
    Console.WriteLine($"\nDetalhes {ex?.StackTrace?.ToString()}");

}
finally
{
    Console.WriteLine("\nProcessamento concluido");
}
