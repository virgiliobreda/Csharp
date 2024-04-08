//1- Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor
using System.Drawing;

int idade = 35;
Console.WriteLine(idade);
//2- Crie uma variável chamada nome e  atribua o valor "Maria" e exiba o seu valor
string nome = "Maria";
Console.WriteLine(nome);
//3- Crie uma variável chamada altura e atribua a ela o valor 3.45.
double altura = 3.45;
// 4- Crie uma variável chamada data e atribua a ela a data 04/09/1999 e exiba o seu valor.
DateTime data = new DateTime(1999, 9, 4);
Console.WriteLine(data);
//5- Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor
int ANO = 12;
Console.WriteLine(ANO);
//6- Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o valor 7.80 e exiba o seu valor
double? nota = 7.80;
Console.WriteLine(nota);
//7- Quais as diferenças entre os tipos por valor e os tipos por referência ?


/*
 -tipos valor não podem ser nulos
 -tipos valor ficam na memoria stack
 -tipos referencia ficam na memoria heap
 */

/*
  8- Inclua o tipo de dados correto entre os parênteses nas seguintes declarações de variáveis:
(double)  numero = 7.99;               
(DateTime)  hoje =  DateTime.Now;             
(char)  letra = 'C';               
(float)  temperatura = 27.4f;               
(bool)  ativo  = false;               
(string)  nome = "Manoel";               
(decimal)  salario = 950.99m;               
(int)  x = 10;   
 */

/*
  9- Dada as variáveis declaradas a seguir classifique-as em tipos por valor(V) e tipos por 
referência (R) :
(v) int n = 1;      
(r) string titulo = "A vida";      
(v) float f = 12.45f;   
(v) double d = 5.45;    
(v) decimal valor = 10.99m;     
(v) char sexo = ‘M’;     
(r) object o = null;     
 */

//10- O que é um nullable type e qual a sua utilidade ?
/* um recurso que permite atribuir valores nulos em a um tipo de dado que por padrão não aceita valor nulo
 * sua ultilidade esta em deixar um valor null para uma aplicação conjunta com o banco de dados por exemplo
 */
//11 - O que é Camel Case ? Dê um exemplo de sua aplicação.
/*
 * estilo de nomeclatura de texto
 * minhaIdade
 */

//12- O que é Pascal Case ? Dê um exemplo de sua aplicação.
/*
 * estilo de nomeclatura de texto
 * MinhaIdade
 */

/* 13- Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a 
seguir imprima o valor da soma de x com y. (Use o operador aritmético + para realizar a 
operação de soma */

int x = 77;
int y = 66;
int soma = x + y;
Console.WriteLine(soma);

// 14- Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e string
/*
 * bool = false;
 * char = null;
 * double = 0;
 * float = 0;
 * decimal = 0;
 * string = null;
 */

/* 15- Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis 
considerando a nomenclatura usada:
(F) double 1valor = 12.45;      
(F) string #nome = "Pedro";      
(V) float _temperatura = 12.45f;      
(F) double int = 5;      
(F) decimal renda extra = 91.45m;     
(F) bool status$conta = false;     
(V) string titulo3 = “Tópico 1”;       
(V) float salario_mensal = 1999.55f;     
(V) int percentualValorDesconto = 5;      
(V) const bool MENSALIDADE_EM_DIA = true;
*/









