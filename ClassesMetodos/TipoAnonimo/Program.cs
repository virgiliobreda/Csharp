var alunos = new[]
{
    new{ id= 1, nome = "paulo", idade = 20},
    new{ id= 2, nome = "paulim", idade = 21}
};

foreach (var aluno in alunos)
{
    Console.WriteLine($"{aluno.nome}, {aluno.idade}");
}