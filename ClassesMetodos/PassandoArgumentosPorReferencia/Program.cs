Console.WriteLine("## Passando argumentos por referência ##");

int x = 20;
Console.WriteLine("\nValor do argumento x antes de passar por valor " + x);
Calculo c = new();
c.Dobrar(ref x);
Console.WriteLine("Valor do argumento x depois de passar por valor " + x);


Console.ReadKey();

public class Calculo
{
    public void Dobrar(ref int y)
    {
        y *= 2;
        Console.WriteLine($"Valor do parâmetro y no método dobrar {y}");
    }
}