using Exercise.Entities;
using System.Collections.Immutable;
using System.Globalization;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Product> listProduct = new List<Product>();

            using (StreamReader sreader = File.OpenText(path))
            {
                while (!sreader.EndOfStream)
                {
                    string[] filds = sreader.ReadLine().Split(",");
                    string name = filds[0];
                    double price = double.Parse(filds[1],CultureInfo.InvariantCulture);

                    listProduct.Add(new Product(name, price));
                }
            }

            double avg = listProduct.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            //var names = listProduct.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            var names =
                (from n in listProduct
                 where n.Price < avg
                 orderby n.Name descending
                 select n.Name);

            foreach (string n in names)
            {
                Console.WriteLine(n);
            }
        }
    }
}