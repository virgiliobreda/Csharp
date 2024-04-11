Console.WriteLine("## Operadores Aritméticos ##\n");

Console.Write("Informe o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Informe o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nRaiz quadrada de x = {Math.Sqrt(x)}");
Console.WriteLine($"\nPotencia de x elevado a y = {Math.Pow(x, y)}");
Console.WriteLine($"\nValor mínimo entre x e y = {Math.Min(x, y)}");
Console.WriteLine($"\nValor máximo entre x e y = {Math.Max(x, y)}");
Console.WriteLine($"\nCoseno de x  = {Math.Cos(x)}"); 
Console.WriteLine($"\nSeno de x = {Math.Sin(x)}");
Console.WriteLine($"\nExponencial de x = {Math.Exp(x)}");


//Console.WriteLine($"\nsoma de x + y = {x + y}");
//Console.WriteLine($"subtração de x - y = {x - y}");
//Console.WriteLine($"multiplicação de x * y = {x * y}");
//double divisao =(double)x / y;
//Console.WriteLine($"divisão de x / y = {divisao}");
//Console.WriteLine($"módulo de x % y = {x % y}");

Console.ReadKey();