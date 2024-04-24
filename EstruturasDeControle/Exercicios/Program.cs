//Console.WriteLine("Encontre o maior dentre 3 números: ");

//Console.Write("Primeiro Número:\t");
//var n1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Segundo Número:\t");
//var n2 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Terceiro Número:\t");
//var n3 = Convert.ToInt32(Console.ReadLine());
//var maior = 0;

//if (n1 > n2 && n1 > n3)
//{
//    maior = n1;
//}
//else if (n2 > n1 && n2 > n3)
//{
//    maior = n2;
//}
//else
//{
//    maior = n3;
//}

//Console.WriteLine($"O maior número é {maior}");

// 2

//int a, b, c;
//double d, x1, x2;

//Console.WriteLine("Calculo equação segundo grau:");

//Console.Write("valor de a: "); 
//a = Convert.ToInt32(Console.ReadLine());
//Console.Write("valor de b: ");
//b = Convert.ToInt32(Console.ReadLine());
//Console.Write("valor de c: ");
//c = Convert.ToInt32(Console.ReadLine());

//d = Math.Pow(b, 2) - 4 * a * c;

//if (d == 0)
//{
//    Console.WriteLine("As raizes são iguais\n");
//    x1 = -b / (2 * a);
//    x2 = x1;
//    Console.WriteLine($"Primeira raiz x1 = {x1}");
//    Console.WriteLine($"Segunda raiz x2 = {x2}");
//}
//else if(d > 0)
//{
//    Console.WriteLine("Ambas raizes são reais e diferentes");
//    x1 = (-b + Math.Sqrt(d)) / (2 * a);
//    x2 = (-b - Math.Sqrt(d)) / (2 * a);
//    Console.WriteLine($"Primeira raiz x1 = {x1}");
//    Console.WriteLine($"Segunda raiz x2 = {x2}");
//}
//else
//{
//    Console.WriteLine("Sem solução");
//}

//Console.WriteLine("Os 10 primeiros números naturais são: \n");
//var sum = 0;

//for (int i = 1; i <= 10; i++)
//{
//    Console.Write(i + " ");
//    sum += i;

//}
//Console.WriteLine();
//Console.WriteLine($"\nA soma dos números é {sum}");

//4
//while (true)
//{
//    Console.Write("\nDigite um número para saber sua tabuada: ");
//    var n = Convert.ToInt32(Console.ReadLine());
//    if (n <= 0)
//    {
//        Console.WriteLine("Digite um número maior do que 0");
//        continue;
//    }
//    if (n == 666)
//    {
//        Console.WriteLine("\nFim de processamento...");
//        break;
//    }

//    for (int i = 1; i <= 10; i++)
//    {
//        Console.WriteLine($"{n} x {i} = {n * i}");
//    }

//    Console.WriteLine("\nDigite 666 se quiser sair");
//}
//5

//bool condicao = true;

//while (condicao)
//{
//    Console.WriteLine("Qual a instrução para sair de um loop?");
//    Console.WriteLine("a.quit");
//    Console.WriteLine("b.continue");
//    Console.WriteLine("c.break");
//    Console.WriteLine("d.decimal");
//    var resp = Console.ReadLine();

//    if (resp.ToLower() == "c")
//    {
//        Console.WriteLine("Você acertou");
//    }
//    else if (resp.ToLower() == "x")
//    {
//        Console.WriteLine("Programa encerrado");
//        condicao = false;
//    }
//    else
//    {
//        Console.WriteLine("Resposta errada");
//    }
//}

//for (var i = 10; i <= 20; i++)
//{
//    if (i == 16)
//    {
//        continue;
//    }

//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }

//}

//7
//Console.WriteLine("Linhas: ");
//var linhas = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i <= linhas; i++)
//{
//    for (int j = 1; j <= i; j++)

//        Console.Write("*");
//        Console.WriteLine();

//}
//8

//Console.Write("Digite um número: ");
//var n = Convert.ToInt32(Console.ReadLine());
//var fat = 1;
//for (int i = 1; i <= n; i++)

//    fat = fat * i;

//Console.WriteLine(fat);

//int n = 2;

//do
//{
//    var mult = 1;
//    do
//    {
//        Console.WriteLine($"{n} x {mult} = {n * mult}");
//        mult++;
//    }
//    while (mult <= 10);
//    Console.WriteLine();
//    n++;
//}
//while (n <= 6);

//while (true)
//{
//    Console.WriteLine("Digite a nota do aluno (666 sai)");
//    var nota = Convert.ToInt32(Console.ReadLine());
//    if (nota == 666)
//    {
//        break;
//    }
//    switch (nota) 
//    { 
//        case 10: 
//            Console.WriteLine("A+");
//            break;
//        case 9:
//            Console.WriteLine("A");
//            break;
//        case 8:
//        case 7:
//            Console.WriteLine("B");
//            break;
//        case 6:
//            Console.WriteLine("C");
//            break;
//        case 5:
//            Console.WriteLine("E");
//            break;
//        default:
//            Console.WriteLine("F");
//            break;
//    }
//}

while (true)
{
    Console.WriteLine("Informe o primeiro número");
    int n1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Informe o operando (+,-,*,/)");
    string op = Console.ReadLine();
    Console.WriteLine("Informe o segundo número");
    int n2 = Convert.ToInt32(Console.ReadLine());

    switch (op)
    {

        case "+":
            Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
            break;
        case "-":
            Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
            break;
        case "*":
            Console.WriteLine($"{n1} * {n2} = {n1 * n2}");
            break;
        case "/":
            Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
            break;
    }
}