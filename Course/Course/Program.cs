using System;

namespace Course 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool completo = false;

            sbyte x = 100;

            x++;

            Console.WriteLine(x);  
            Convert.ToInt16(x);

            x = 11;


            int y = 125;
            y--;
            --y;
         
            long z = 2147483648L;
            char genero = 'F';
            char letra = '\u0041';
            string nome = "Paula";
            object obj1 = 'a';
            object obj2 = 4.5;

            Console.WriteLine(completo);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
        }
    }
}