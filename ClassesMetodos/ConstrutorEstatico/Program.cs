Console.WriteLine("Construtor Estático");


Pessoa p1 = new(19, "Maria");

Console.WriteLine(p1.Nome +" - " + p1.Idade);
Console.WriteLine("Idade Mínima = " + Pessoa.IdadeMinima);

Pessoa p2 = new(29, "Manuel");
Console.WriteLine(p2.Nome + " - " + p2.Idade);
Console.WriteLine("Idade Mínima = " + Pessoa.IdadeMinima);

Console.ReadKey();
