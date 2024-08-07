Console.WriteLine("Propriedades");

Produto p1 = new();
p1.Nome = "Caderno";
p1.Preco = 3;
p1.EstoqueMinimo = 10;

p1.Exibir();


public class Produto
{
    public string? Nome { get; set; }

    private double preco;
    public double Preco
    {
        get { return preco; }
        set
        {
            if (value < 5.00)
                preco = 5;
            else
                preco = value;
        }
    }
    private double desconto = 0.05;
    public double Desconto { get { return desconto; } }
    

    public double PrecoFinal { get { return preco - (Preco * Desconto); } }
    private int estoqueMinimo;
    public int EstoqueMinimo { set { estoqueMinimo = value;  } }

    public void Exibir()
    {
        Console.WriteLine($"{Nome} \n{Preco.ToString("c")} \n{Desconto} " +
                          $"\n{PrecoFinal.ToString("c")} \n{estoqueMinimo}");
    }




}