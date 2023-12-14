﻿namespace HashSetAndSortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            
            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook"));

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}