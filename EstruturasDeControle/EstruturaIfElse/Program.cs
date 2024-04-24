Console.WriteLine("## Instrução if-else ##\n");

Console.Write("Informe a nota do aluno: ");
var nota = Convert.ToInt32(Console.ReadLine());

if (nota > 5)
{
    Console.WriteLine("Aluno aprovado");
}
else
{
    Console.WriteLine("Aluno reprovado");
}

Console.ReadKey();