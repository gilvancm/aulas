using System;
using System.Globalization;
using Aula130cp.Entities;
using System.Collections.Generic;

namespace Aula130cp
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<Employee> list = new List<Employee>();
            Console.WriteLine("resolvido por gilvan");

            List<Employee> employees = new List<Employee>();


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
                    Console.WriteLine();
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                   
                    Employee emp = new Employee(name, hours, valuePerHour);
                    // emp.AddEmployee(emp);


                    // list.Add(new Employee(name, hours, valuePerHour));
                    employees.Add(emp);

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

                    //empout.AddEmployee(empout);
                    employees.Add(empout);

                    empout.AddOutsourcedEmployee(empout);
                   
                    Console.WriteLine();
                    Console.WriteLine(empout);

                }

                

            }

            Console.WriteLine();

            Console.WriteLine("PAYMENTS:");

            foreach (Employee empl in employees)

            {

                Console.WriteLine(empl.Name + " - $ " + empl.Payment().ToString("F2", CultureInfo.InvariantCulture));

            }



        }
    }
}
