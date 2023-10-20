using System.Globalization;

namespace ExercicioFixacaoBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Entre com o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial? (s/n) ");
            string decisao = Console.ReadLine();



            Conta c1 = new Conta(numeroConta, nome);

            if (decisao == "s")
            {
                Console.Write("Entre com o valor do deposito inicial: ");
                double depositoInicial = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c1.Deposito(depositoInicial);
                
            }

            Console.WriteLine("\nDados da conta: \n" + c1);

            Console.Write("\nEntre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Deposito(deposito);
            Console.WriteLine("\nDados da conta atualizados: \n" + c1);

            Console.Write("\nEntre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Saque(saque);

            Console.WriteLine("\nDados da conta atualizados: \n" + c1);











        }
    }
}