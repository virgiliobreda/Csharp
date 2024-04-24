//Console.WriteLine("## Estrutura switch case ##");

//int valor = 600;
//Console.WriteLine("Valor da compra R$ 600,00");
//Console.Write("Informe o número de parcelas (1 a 3): ");
//int numeroParcelas = Convert.ToInt32(Console.ReadLine());


//switch (numeroParcelas)
//{
//    case 1:
//        Console.WriteLine($"\nPrestação R$ {valor / numeroParcelas}");
//        break;
//    case 2:
//        Console.WriteLine($"\nPrestação R$ {valor / numeroParcelas}");
//        break;
//    case 3:
//        Console.WriteLine($"\nPrestação R$ {valor / numeroParcelas}");
//        break;
//    default:
//        Console.WriteLine("\nValor inválido, informe 1,2 ou 3");
//        break;
//}

//Console.WriteLine("Informe um número inteiro");
//int numero = Convert.ToInt32(Console.ReadLine());

//switch (numero % 2)
//{
//    case 0:
//        Console.WriteLine($"\n{numero} é par");
//        break;
//    case 1:
//        Console.WriteLine($"\n{numero} é impar");
//        break;
//}

//Console.Write("Informe o nome de um mês: ");
//var mes = Console.ReadLine().ToLower();
//switch (mes)
//{
//    case "janeiro":
//    case "março":
//    case "maio":
//    case "julho":
//    case "agosto":
//    case "outubro":
//    case "dezembro":
//        Console.WriteLine("Este mês tem 31 dias");
//        break;
//    case "fevereiro":
//        Console.WriteLine("Este mês tem 28 ou 29 dias");
//        break;
//    default:
//        Console.WriteLine("Este mês tem 30 dias");
//        break;
//}
//Console.WriteLine("Fim processamento");


//Console.ReadKey();

int cargo = 0;
int funcao = 0;
Console.WriteLine("Você é gerente(1) ou programador(2)\t");
cargo = Convert.ToInt32(Console.ReadLine());

if  (cargo == 2)
{
    Console.WriteLine("Você é junior(1) ou senior(2)? ");
    funcao = Convert.ToInt32(Console.ReadLine());
}
switch (cargo) 
{
    case 1:
        Console.WriteLine("Bem vindo gerente");
        break;
    case 2:
        Console.WriteLine("Bem vindo programador");
        switch (funcao)
        {
            case 1:
                Console.WriteLine("Você é junior");
                break;
            case 2:
                Console.WriteLine("Você é senior");
                break;
            default:
                Console.WriteLine("função desconhecida");
                break;
        }
        break;
    default:
        Console.WriteLine("\nNão consigo te identificar");
        break;
}