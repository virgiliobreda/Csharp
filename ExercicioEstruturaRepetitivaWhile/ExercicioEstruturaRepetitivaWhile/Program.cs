namespace ExercicioEstruturaRepetitivaWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício 1 
            //int x = 0;
            //while (x != 2002)
            //{
            //    Console.Write("Digite a senha: ");
            //    x = int.Parse(Console.ReadLine());

            //    if (x != 2002)
            //    {
            //        Console.WriteLine("Senha invalida");
            //    }
            //}

            //Console.WriteLine("Acesso permitido");

            // Exercício 2


            //int x = 1;
            //int y = 1;


            //while (x != 0 && y != 0)
            //{
            //    Console.WriteLine("Digite os valores de x e y");
            //    string[] valores = Console.ReadLine().Split(" ");
            //    x = int.Parse(valores[0]);
            //    y = int.Parse(valores[1]);

            //    if (x > 0 && y > 0)
            //    {
            //        Console.WriteLine("primeiro");
            //    }
            //    else if (x < 0 && y > 0)
            //    {
            //        Console.WriteLine("segundo");
            //    }
            //    else if (x < 0 && y < 0)
            //    {
            //        Console.WriteLine("terceiro");
            //    }
            //    else if (x > 0 && y < 0)
            //    {
            //        Console.WriteLine("quarto");
            //    }
            //}

            // Exercício 3

            int alcool = 0, gasolina = 0, disel = 0;
            

            int opcao = 0;
            while (opcao != 4)
            {
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1) // Álcool
                {
                    alcool += 1;
                }
                else if (opcao == 2) // Gasolina
                {
                    gasolina += 1;
                }
                else if (opcao == 3) // Disel
                {
                    disel += 1;
                }
                else
                {
                    Console.WriteLine("Informe outro valor");
                    continue;
                }
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Álcool = " + alcool);
            Console.WriteLine("Gasolina = " + gasolina);
            Console.WriteLine("Disel = " + disel);


        }
    }
}