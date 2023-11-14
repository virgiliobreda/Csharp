using EnumFix1.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumFix1.Entities
{
    internal class Order
    {
        public DateTime Momment { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime momment, OrderStatus status, Client client)
        {
            Momment = momment;
            OrderStatus = status;
            Client = client;
        }
        
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total() {
            
            double sum = 0.0;
            
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order momment: " + Momment.ToString("dd/MM/yyyy"));
            sb.AppendLine("Order Status: " + OrderStatus);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items: ");

            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine($"Total price ${Total().ToString("F2",CultureInfo.InvariantCulture)}");
            
            return sb.ToString();
               
        }
    }
}
