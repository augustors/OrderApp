using CompositionExercise3.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionExercise3.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public Client? Client { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public List<OrderItem> Status { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, Client client, OrderStatus status)
        {
            Moment = moment;
            Client = client;
            OrderStatus = status;
        }

        public void AddItem(OrderItem status)
        {
            Status.Add(status);
        }

        public void RemoveItem(OrderItem status)
        {
            Status.Remove(status);
        }

        public double Total()
        {
            double total = 0;
            foreach (OrderItem item in Status)
            {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine("Order moment: " + Moment);
            sb.AppendLine("Order status: " + OrderStatus);
            sb.AppendLine("Client: " + Client.Name);
            sb.AppendLine("Order items: ");
            foreach (OrderItem item in Status)
            {
                sb.AppendLine(item.Product.Name + ", Quantity: " + item.Quantity + ", " + "Subtotal: " + item.SubTotal());
            }
            sb.AppendLine("Total price: $" + Total());
            
            return sb.ToString();
        }
    }
}
