using EnumFix1.Entities;
using EnumFix1.Entities.Enums;
using System.Globalization;

namespace EnumFix1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the client data: ");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();
            Console.WriteLine("Birth date (DD/MM/YYYY)");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(clientName, clientEmail, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0;  i < n; i++)
            {
                Console.WriteLine($"Enter the #{i} item data: ");
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) ;

                Product product = new Product(productName, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine()) ;

                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);

            }
            Console.WriteLine();

            Console.WriteLine("Order Summary:");
            Console.WriteLine(order);
        }
    }
}