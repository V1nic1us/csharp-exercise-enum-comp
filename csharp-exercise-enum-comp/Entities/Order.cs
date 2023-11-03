using csharp_exercise_enum_comp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exercise_enum_comp.Entities
{
    internal class Order
    {
        public Client Client { get; set; }
        public DateTime Moment {  get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(Client client, OrderStatus status)
        {
            Client = client;
            Moment = DateTime.Now;
            Status = status;
        }

        public void addItem(int quantity, Product product)
        {
            Items.Add(new OrderItem(quantity, product));
        }

        public void removeItem(OrderItem orderItem)
        {
            Items.Remove(orderItem);
        }

        public double total()
        {
            double sum = 0;
            foreach (OrderItem item in Items)
            {
                sum = item.price;
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            double total = 0;
            sb.AppendLine("Order Summary");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString());
            sb.Append("Order Status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Cliente: ");
            sb.AppendLine(Client.ToString());
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            foreach (var item in Items)
            {
                total += item.subTotal();
            }
            sb.Append("Total price: ");
            sb.AppendLine(total.ToString());
            return sb.ToString();
        }
    }
}
