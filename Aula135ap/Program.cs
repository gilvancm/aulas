using System;
using Aula135ap.Entities.Enums;
using Aula135ap.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Aula135ap
{
    class Program
    {
        // gilvan resolvel

        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());



            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                char rc = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (rc == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Circle(radius, color));
                }


            }

            Console.WriteLine("SHAPE AREAS: ");

            foreach (Shape shape in list)
            {
                Console.WriteLine("Shape: " + shape.Color + ", Area: " + shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
