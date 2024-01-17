using Action.Entities;

namespace Action
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

            Action<Product> act = p => { p.Price += p.Price * 0.1; };

            products.ForEach(act);

            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }
        }

        static void UpdatePrice(Product product)
        {
            product.Price += product.Price * 0.1;
        }
    }
}