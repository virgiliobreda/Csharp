﻿namespace OperacoesComTimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t1.Add(t2);
            TimeSpan dif = t1.Subtract(t2);
            TimeSpan mult = t2.Multiply(2.0);
            TimeSpan div = t2.Divide(2.0);


            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);












            //TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            //Console.WriteLine(t);

            //Console.WriteLine("Days: " + t.Days);


            //Console.WriteLine("TotalDays: " + t.TotalDays);
            //Console.WriteLine("TotalHours: " + t.TotalHours);
            //Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            //Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            //Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);





            //TimeSpan t1 = TimeSpan.MaxValue;
            //TimeSpan t2 = TimeSpan.MinValue;
            //TimeSpan t3 = TimeSpan.Zero;

            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(t3);
        }
    }
}