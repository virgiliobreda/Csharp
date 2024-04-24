Console.WriteLine("Informe a nota do aluno \t");
var nota = Convert.ToDouble(Console.ReadLine());

if (nota < 5)
{
    Console.WriteLine("\nAluno reprovado");
}
else if (nota >= 5 &&  nota <= 6)
{
    Console.WriteLine("\nAluno em recuperação");
}
else if (nota > 6 && nota <= 10)
{
    Console.WriteLine("\nAluno aprovado");
}

Console.ReadKey();