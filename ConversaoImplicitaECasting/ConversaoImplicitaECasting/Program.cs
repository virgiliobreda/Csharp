using System;

namespace ConversaoImplicitaECasting // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 5;
            int b = 2;


            double resultado = (double) a / b;

            Console.WriteLine(resultado);




            //int b;

            //a = 5.1;
            //b = (int)a;

            //Console.WriteLine(b);
        }
    }
}