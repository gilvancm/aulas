using System;
using System.Collections.Generic;
using Aula122ap.Entities;
using Aula122ap.Entities.Enums;
using System.Globalization;


namespace Aula122ap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
           // OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            DateTime moment = DateTime.Now;

            Client client = new Client(name, email, date);

            Order order = new Order(moment, status,client);
            Console.WriteLine("");

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string namep = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               
                Product product = new Product(namep, price);
                
                Console.Write("Quantity:");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);

               double subt  = orderItem.SubTotal();
               Console.WriteLine("SubTotal: "+subt.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("------------------------------------------");

            }

            Console.WriteLine(order);

           



        }
    }
}
