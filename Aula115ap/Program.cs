using System;
using Aula115ap.Entities;
using Aula115ap.Entities.Enums;

namespace Aula115ap
{
    class Program
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
            Console.WriteLine();
            
            //ccoverte de enumerado pra string
            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine("item teliçence"); 
            Console.WriteLine("conversão de enumeração pra string e de string pra enumeração");
            //     vou parametrizar como se fosse uma lista
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            
            Console.WriteLine("imprime emurerado no formato de string    "+txt);
            Console.WriteLine();
            Console.WriteLine("imprime do formato string para o enumerado    "+os);


        }
    }
}
