namespace EstruturaCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a hora atual?:");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia");
            }
            else if (hora >= 12 && hora < 19)
            {
                Console.WriteLine("Boa Tarde");
            }
            else if (hora >= 19 && hora < 24)
            {
                Console.WriteLine("Boa Noite");
            }
            else 
            { 
                Console.WriteLine("Número invalido");
            }
            
            
            
            
            
            
            
            
            
            
            
            
            //Console.WriteLine("Entre com um número inteiro:");
            //int x = int.Parse(Console.ReadLine());

            //if (x % 2 == 0)
            //{
            //    Console.WriteLine("O número é par");
            //}
            //else
            //{
            //    Console.WriteLine("O número é impar");
            //}










            //int x = 10;

            //Console.WriteLine("Bom dia");

            //if (x > 5)
            //{
            //    Console.WriteLine("Boa tarde");
            //}
            //;
            //Console.WriteLine("Boa noite");
        }
    }
}