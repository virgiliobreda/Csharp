Console.WriteLine("## This ##");

Teste t1 = new Teste(); 
Teste t2 = new Teste();

t1.Num1 = 10;
t1.Num2 = 20;
t1.Exibir();

t2.Num1 = 88;
t2.Num2 = 99;
t2.Exibir();

Teste2 t3 = new Teste2(999);

Console.ReadKey();

public class Teste
{
    public int Num1;
    public int Num2;
    

    public void PassarParametro(Teste t)
    {
        Console.WriteLine($"\nthis = {this}");
        Console.WriteLine($"Num1: {t.Num1}");
        Console.WriteLine($"Num2: {t.Num2}");
    }

    public void Exibir()
    {
        PassarParametro(this);
    }
}

class Teste2
{
    public Teste2(int num1, int num2)
    {
        Console.WriteLine($"\nConstrutor com dois parâmetros {num1}, {num2}");
    }

    public Teste2(int num): this(777, 888)
    {
        Console.WriteLine($"\nConstrutor com um parâmetro " + num);
    }
}