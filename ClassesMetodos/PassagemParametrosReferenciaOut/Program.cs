Console.WriteLine("## Argumentos por referência - out");

double raio = Convert.ToDouble(Console.ReadLine());
Circle circulo = new();
double perimetro = circulo.CalculaAreaPerimetro(raio, out double area);
Console.WriteLine(perimetro);
Console.WriteLine(area);

Console.ReadKey();

public class Circle
{
    public double CalculaAreaPerimetro(double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio, 2);
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
}