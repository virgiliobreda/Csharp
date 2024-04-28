using System.Runtime.InteropServices.JavaScript;

Console.WriteLine("## Métodos - Parâmetros ##\n");

var aluno = new Aluno();
aluno.Nome = "paula";
aluno.Idade = 20;
aluno.Sexo = "feminino";
aluno.Aprovado = "S";

var curso = new Curso();
curso.Resultado(aluno);

Console.ReadKey();

public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}

public class Curso
{
    public void Resultado(Aluno aluno)
    {
        Console.WriteLine($"\nO aluno {aluno.Nome}, sexo {aluno.Sexo} com {aluno.Idade} anos");
        if (aluno.Aprovado == "S")
        {
            Console.WriteLine("\n foi aprovado");
        }
        else
        {
            Console.WriteLine("\n foi reprovado");
        }
    }
}