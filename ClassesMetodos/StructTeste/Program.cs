using System.Runtime.InteropServices;

Cliente cliente1 = new("Maria", "maria@gmail.com", 20);


Cliente.ExibirInfo(cliente1.Nome, cliente1.Email, cliente1.Idade);

Cliente.ExibirInfo(email: cliente1.Email, nome: cliente1.Nome);

public struct Cliente
{
    public string? Nome { get; set; }
    public string? Email { get; set; }
    private int idade;
    public int Idade
    {
        get { return idade; }
        set
        {
            
            if (value < 18)
            {
                idade = 18;
                Console.WriteLine("Cleinte menor que 18 anos");
            }
            else
            {
                Console.WriteLine("Cliente maior que 18 anos");
                value = idade;
            }
        }
    }

    public Cliente(string nome, string email, int idade)
    {
        Nome = nome;
        Email = email;
        Idade = idade;
    }

    public static void ExibirInfo(string nome, string email, int idade = 18)
    {
        Console.WriteLine($"{nome} \n{email} \n{idade.ToString()}");
    }
}
