Console.WriteLine("## Passando argumentos por valor ##");

int x = 20;
Console.WriteLine("\nValor do argumento x antes de passar por valor " + x);
Calculo c = new();
c.Dobrar(x);
Console.WriteLine("Valor do argumento x depois de passar por valor " + x);


Console.ReadKey();

public class Calculo
{
    public void Dobrar(int y)
    {
        y *= 2;
        Console.WriteLine($"Valor do parâmetro y no método dobrar {y}");
    }
}