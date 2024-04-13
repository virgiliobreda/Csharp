Console.WriteLine("## Operador uniário e ternário ##");

Console.Write("Informe o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Informe o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());

string resultado = x > y ? "X é maior que Y" :
                   x < y ? "X é menor do que Y" :
                   x == y ? "X é igual a Y" : "Sem resultados";
Console.WriteLine(resultado);
Console.ReadKey();