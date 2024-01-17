using Func.Entities;

namespace Func
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> p = new List<Product>();

            p.Add(new Product("TV", 900));
            p.Add(new Product("Mouse", 50));
            p.Add(new Product("Tablet", 350));
            p.Add(new Product("HD Case", 80.90));

            Func<Product, string> func = p => p.Name.ToUpper();

            List<string> result = p.Select(func).ToList();

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }

        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}