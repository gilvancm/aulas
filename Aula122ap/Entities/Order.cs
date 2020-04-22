using System;
using System.Collections.Generic;
using System.Text;
using Aula122ap.Entities.Enums;
using System.Globalization;
using Aula122ap.Entities;

namespace Aula122ap.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
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

        public double Total(){
                double sum = 0;

                foreach (OrderItem item in Items)
                {
                    sum += item.SubTotal();
                }

                return sum;
        }
       

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Status: ");
            sb.AppendLine(Status.ToString());
            sb.Append(Client);
            sb.AppendLine(" ");
            sb.AppendLine("Order items: ");


            foreach(OrderItem item in Items) {

                sb.AppendLine(item.ToString());
            
            }

            sb.AppendLine(" ");
            sb.AppendLine("Total Price: "+Total().ToString("F2", CultureInfo.InvariantCulture)); 

            return sb.ToString();
        }

    }
}
