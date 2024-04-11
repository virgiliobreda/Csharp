Console.WriteLine("## Inferência de tipos (var) ##\n");

var idade = 25;
var nome = "Maria";
var salario = 2500.00m;

Console.WriteLine($"{nome} tem {idade} anos e ganha {salario.ToString("c")}");

//var limitações
//var salario = null;
//var titulo;
//var salario, imposto, total;

//não pode mudar o tipo após inicializar
//var num = 10;
//num = num + 20;
//num = "Teste";
var teste = new Teste();

Console.ReadKey();

class Teste { 
    public void MeuMetodo()
    {
        Console.WriteLine("Meu método");
    }
}
