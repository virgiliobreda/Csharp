namespace SortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 }; 
            SortedSet<int> b = new SortedSet<int>() { 5, 6 ,7 , 8, 9, 10 };

            Console.Write("A: ");
            PrintCollection(a);
            Console.Write("B: ");
            PrintCollection(b);

            // Union 

            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            Console.Write("Union: ");
            PrintCollection(c);

            // Intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            Console.Write("Intersection: ");
            PrintCollection(d);

            // Difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            Console.Write("Exception: ");
            PrintCollection(e);

        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}