using System.Globalization;
using System.Runtime.InteropServices;

namespace ExercicioConversorMoeda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dolar?: ");
            double cotacao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar?: ");
            double quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double valorAPagar = ConversorDeMoeda.DolarParaReal(quantia, cotacao);

            Console.Write("Valor a ser Pago em reais = " + valorAPagar);

        }
    }
}