// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Funcionario funci = new();
funci.Nome = "José";
funci.Email = "jose@gmail.com";
funci.Empresa = "google";
funci.Salario = 9000;

Console.WriteLine("Funcionario");
Console.WriteLine(funci.Empresa);
Console.WriteLine(funci.Salario);
funci.Indentificar(); 

Aluno aluno = new Aluno();
aluno.Nome = "João";
aluno.Email = "joao@gmail.com";
aluno.Curso = "engenharia";
aluno.Nota = 10;
Console.WriteLine(aluno.Curso);
Console.WriteLine(aluno.Nota);
aluno.Indentificar();


public class Pessoa
{
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public void Indentificar()
    {
        Console.WriteLine($"{Nome } - {Email}");
    }
}

public class Funcionario : Pessoa
{
    public string? Empresa { get; set; }
    public decimal Salario { get; set; }
}

public class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public int Nota { get; set; }
}