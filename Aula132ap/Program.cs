using System;
using System.Collections.Generic;
using System.Globalization;
using Aula132ap.Entities;

namespace Aula132ap
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char s = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (s == 'c')
                {

                    list.Add(new Product(name, price));

                }

                if(s == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new ImportedProduct(name, price, customsFee));
                }
                if(s == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                }


            }

            Console.WriteLine("PRICE TAGS: ");
            Console.WriteLine();
            
            foreach (Product l in list)
            {
                Console.WriteLine(l);

            }


        }
    }
}
