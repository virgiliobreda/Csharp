using Predicate.Entities;

namespace Predicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Product("TV", 900));
            products.Add(new Product("Mouse", 50));
            products.Add(new Product("Tablet", 350));
            products.Add(new Product("HD Case", 80.90));

            products.RemoveAll(ProductTest);
            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100;
        }
    }
}