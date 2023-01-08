using Atividade3.Entities.Enums;
using System.Text;

namespace Atividade3.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; } = null!;
        private List<OrderItem> OrdersItems = new List<OrderItem>();
        
        public Order(Client client, DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Client = client;
            Status = status;
        }

        public void addItem(OrderItem item)
        {
            OrdersItems.Add(item);
        }

        public void removeItem(OrderItem item)
        {
            OrdersItems.Remove(item);
        }

        public double Total()
        {
            double total = 0.0;

            foreach (OrderItem Item in OrdersItems)
            {
                total += Item.subTotal();
            }
            
            return total;
        }

        public override string ToString()
        {
            StringBuilder orderText = new StringBuilder();

            orderText.Append("Order moment: ");
            orderText.AppendLine(Moment.ToString());
            orderText.Append("Order status: ");
            orderText.AppendLine(Status.ToString());
            orderText.Append("Client: ");
            orderText.Append(Client.Name);
            orderText.Append($" ({Client.birthDate.Date.ToString("dd/MM/yyyy")}) ");
            orderText.AppendLine($"- {Client.Email}");
            orderText.AppendLine("Order items:");

            for (int i = 0; i < OrdersItems.Count; i++)
            {
                orderText.AppendLine(OrdersItems[i].ToString());
            }

            orderText.AppendLine($"Total price: ${Total().ToString("F2")}");



            return orderText.ToString();
        }


/*
        ORDER SUMMARY:
        Order moment: 20/04/2018 11:25:09
        Order status: Processing
        Client: Alex Green (15/03/1985) - alex@gmail.com
        Order items:
        TV, $1000.00, Quantity: 1, Subtotal: $1000.00
        Mouse, $40.00, Quantity: 2, Subtotal: $80.00
        Total price: $1080.00
*/
    }
}