Console.WriteLine("Saída de dados : Formatação");
Console.WriteLine();

int idade = 25;
string nome = "Maria";
Console.Write(nome);
Console.WriteLine(idade);

//Escreve na mesma linha 'maria tem 25 anos'
Console.Write(nome);
Console.Write(" tem ");
Console.Write(idade);
Console.Write(" anos \n");


//usar a concatenação : usando o operador +
Console.WriteLine(nome + " tem " + idade + " anos ");

//usar a interpolação de string : $ -> a interpolação {}
Console.WriteLine($"{nome} tem {idade} anos");

//usar place holders : usa {} com numeração com inicio em zero
Console.WriteLine("{0} tem {1} anos", nome, idade);

Console.ReadLine();
