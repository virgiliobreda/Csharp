public class Pessoa
{
    public static int IdadeMinima;

    public int Idade { get; set; }
    public string? Nome { get; set; }

    public Pessoa(int idade, string nome)
    {
        Console.WriteLine("\nExecutando o construtor parametrizado");
        Idade = idade;
        Nome = nome;
    }
    public Pessoa()
    {

    }

    static Pessoa()
    {
        IdadeMinima = 18;
        Console.WriteLine("Executando construtor estático");
        Console.WriteLine("Inicializando idade minima");
    }

}