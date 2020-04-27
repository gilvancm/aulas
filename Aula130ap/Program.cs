using System;
using System.Globalization;
using System.Collections.Generic;
using Aula130ap.Entities;

namespace Aula130ap
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Enter the number of employees: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (n/y)? ");
                Char OutEmp = char.Parse(Console.ReadLine());

                if (OutEmp == 'n')
                {
                    Console.WriteLine( );
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Employee emp = new Employee(name, hours, valuePerHour);

                    emp.AddEmployee(emp);

                    Console.WriteLine();
                    Console.WriteLine(emp);

                }
                else
                {
                    Console.WriteLine();
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Additional charge: ");
                    double aAdditionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    OutsourcedEmployee empout = new OutsourcedEmployee(name, hours, valuePerHour, aAdditionalCharge);

                    empout.AddEmployee(empout);

                    Console.WriteLine();
                    Console.WriteLine(empout);
                    
                }

            }

           
        }
    }
}
