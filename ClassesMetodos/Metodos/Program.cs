Console.WriteLine("## Métodos ##");

MinhaClasse x = new MinhaClasse();

x.Saudacao("Paula", DateTime.Now.ToShortDateString());

Console.ReadKey();

 class MinhaClasse()
{
    public void Saudacao(string nome, string data)
    {
        Console.WriteLine(nome);
        Console.WriteLine(data);
    }
}