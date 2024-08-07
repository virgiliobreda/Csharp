Console.WriteLine("Métodos Estáticos");

Console.ReadKey();

Console.WriteLine(Calculadora.Somar(10, 20));
Console.WriteLine(Calculadora.Subtrair(10, 20));

public class Calculadora
{
    public static int Somar(int n1, int n2)
    {
        return n1 + n2;
    }
    public static int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }
}