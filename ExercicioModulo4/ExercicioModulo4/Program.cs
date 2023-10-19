using System.Globalization;

namespace ExercicioModulo4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Exercício 1
            //Retangulo ret = new Retangulo();

            //Console.WriteLine("Entre a largura e altura do retângulo: ");
            //ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            //Console.WriteLine("AREA: " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("PERÉMETRO: " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("DIAGONAL: " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));


            // Exercício 2

            //Funcionario func = new Funcionario();

            //Console.Write("Nome: ");
            //func.Nome = Console.ReadLine();
            //Console.Write("Salário Bruto: ");
            //func.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            //Console.Write("Imposto: ");
            //func.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            //Console.WriteLine("Funcionario: " + func);

            //Console.Write("Digite a porcentagem para aumentar o salário: ");
            //double aumentar = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            //func.AumentarSalario(aumentar);

            //Console.WriteLine("Dados atualizados: " + func);

            // Exercício 3

            Aluno al = new Aluno();

            Console.Write("Nome do aluno: ");
            al.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            Console.WriteLine();
            al.Nota1 = double.Parse(Console.ReadLine());
            al.Nota2 = double.Parse(Console.ReadLine());
            al.Nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Nota final: " + al.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            
            if (al.Aprovado() == true)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + al.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                + " Pontos");
            }


        }
    }
}