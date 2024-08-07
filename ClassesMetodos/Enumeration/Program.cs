using Enums;



Console.WriteLine("Enum");

Console.WriteLine((int)DiasDaSemana.Quarta);
Console.WriteLine(DiasDaSemana.Domingo);
int dia5 = (int)DiasDaSemana.Sexta;
Console.WriteLine(dia5);
Console.WriteLine();

Console.WriteLine($"{Categorias.Moda} - {(int)Categorias.Moda}");

int? valor = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((Categorias)valor);


