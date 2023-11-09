using Enum1.Entites;
using Enum1.Entites.Enums;

namespace Enum1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");


            Console.WriteLine(os);

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);
        }
    }
}