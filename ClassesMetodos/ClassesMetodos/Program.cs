Console.WriteLine("## Classes e Métodos ##\n");


Pessoa p1 = new Pessoa();
p1.name = "Paula";
p1.idade = 20;
p1.sexo = "F";

Console.WriteLine($"{p1.name}, {p1.idade}, {p1.sexo}");





Console.ReadKey();


class Pessoa {
    public string? name;
    public int idade;
    public string? sexo;
}
