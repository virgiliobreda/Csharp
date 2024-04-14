using Microsoft.VisualBasic;

/*1 - Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato :  
Aluno<nome> tem<idade> anos e nota<nota> usando a concatenação e a interpolação de strings */

//var nome = "Paulo";
//var idade = 17;
//var nota = 7.5;

//Console.WriteLine($"Aluno {nome} tem {idade} anos e nota {nota}");

/* 2- Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de 
escapes. */

//Console.WriteLine($"\nAluno {nome} \ntem {idade} anos \ne nota {nota}");

/*3- Para qual tipo de dados você pode converter um float implicitamente ?
() int 
(x) double 
() long  
(x) decimal
*/

/*
 * 4- Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ? 
() int para long 
(x) double para long
(x) double para float
(x) decimal para float 
(x) long para int 
(x) double para decimal 
*/

/*
 * 5- Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando 
a concatenação e também a interpolação de strings
*/

//string letra1 = Console.ReadLine();
//string letra2 = Console.ReadLine();
//string letra3 = Console.ReadLine();

//Console.WriteLine($"{letra3}, {letra2}, {letra1}");

/*
 *  6- Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
(f)long resultado = 1.32;     
(v)var nome = “Maria”;  
(v)string resultado =  100.ToString();   
(v)A sequência de escape \n inclui uma nova linha   
(f)float f  = 5.45;      
(v)decimal valor = (decimal) 10.99f;     
(f)var status = null;     
(v)object o = 12.45m;     
(v)string titulo =  true.ToString()
(f)A sequencia \t inclui uma tabulação vertical;
*/

/*
 * 7- Escreva um programa para receber dois valores via teclado do tipo double e a seguir 
realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo 
exibindo o resultado
 */

//double valor1 = Convert.ToDouble(Console.ReadLine());
//double valor2 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine($"\nSoma = {valor1 + valor2} \nSubtração = {valor1 - valor2}" +
//    $"\nMultiplicação = {valor1 * valor2}\nExponenciação = {Math.Pow(valor1,valor2)}" +
//    $"\nDivisão = {valor1 / valor2} \nMódulo = {valor1 % valor2}");

/* 8 - Faça um programa para calcular o resultado da fórmula de baskara dados os valores de 
a b e c .*/
//int a = 1;
//int b = 12;
//int c = -13;

//double delta = Math.Pow(b, 2) -4 * a * c;
//double x1 = ((-b) + Math.Sqrt(delta)) / (2 * a); 
//double x2 = ((-b) - Math.Sqrt(delta)) / (2 * a);
//Console.WriteLine(x1);
//Console.WriteLine(x2);

/*
 9- Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e 
Senha é um inteiro. Se o nome for igual a ‘admin’  ou ‘maria’ e a senha for igual a ‘123’ 
então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login 
inválido’: (use o operador condicional ternário)*/
//string nome = Console.ReadLine();
//int senha = Convert.ToInt32(Console.ReadLine());



//var resultado = (nome == "maria" || nome == "admin") && senha == 123 ? "Login feito com sucesso" : "Login inválido";
//Console.WriteLine(resultado);

/*
 10- Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis considerando 
a nomenclatura usada:
(v) string? nome; é um exemplo de nullable reference type   
(f) para x igual a 0 , Console.WriteLine(x++);  imprime o valor 1     
(f) A ordem de precedência dos operadores lógicos é :  ! , || e && (NOT, OR e AND)   
(v) para y igual a 0 , Console.WriteLine(++y);  imprime o valor 1     
(f) (10 % 2 == 0) ? “Par” : “Impar”;    Vai retornar “Impar”     
(f) Para x=25 e y=5 , a expressão ( y >= x ) && ( y <= x );  retorna true;   
(v) Os nullable reference types emitem um alerta em tempo de compilação para uso do null     
(f) Para x = 10 , o código Console.WriteLine(x+=x);  imprime o valor 10;   
(f) Para x= 5 , a expressão !(9 >= x) && x <= 7 || x == 5); retorna false;     
(v) O operador ?. permite verificar se um objeto é null e evitar o NullReferenceException   
(v) Qualquer tipo de dado pode ser declarado como anulável com a ajuda do operador "?*/

/*
 11-Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no 
console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)
*/

//int x = Convert.ToInt32(Console.ReadLine());
//int y = Convert.ToInt32(Console.ReadLine());

//string resultado1 = x % 2 == 0 ? "par" : "impar";
//string resultado2 = y % 2 == 0 ? "par" : "impar";

//Console.WriteLine(resultado1);
//Console.WriteLine(resultado2);

/* 12-Crie um programa que receba um numero inteiro x via teclado e calcule e imprima no 
console o resultado das seguintes operações :   (x^2 -> x ao quadrado) (pi = 3.1415) */

//int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(-6 + x * 5);
//Console.WriteLine((13-2) * x);
//Console.WriteLine((x + -2) * (20 / x));
//Console.WriteLine((12 + x / (x-4)));
//Console.WriteLine(3 * Math.Pow(x,2) + x + 10);
//Console.WriteLine(Math.PI * Math.Pow(x,2));

/*
 13- Considere o seguinte trecho de código:
    int y = 5 ;
    y = (y++)+y+(++y);
    y = 18;
 */

/*
 14- Escreva um programa que solicite a temperatura em graus Celsius e converta para 
Kelvin e Farhenheit usando as fórmulas a seguir */

//Console.Write("Escreva a temperatura em celcius: ");
//double celcius = Convert.ToDouble(Console.ReadLine());

//double farhenheit = (celcius * 9) / 5 + 32;
//double kelvin = celcius + 273;

//Console.WriteLine($"farhenheit = {farhenheit}\n" +
//    $"kelvin = {kelvin}");


Console.ReadKey();