using System;
using Aula119ap.Entities.Enums;
using System.Collections.Generic;
using System.Globalization;
using Aula119ap.Entities;

namespace Aula119ap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkeLevel level = Enum.Parse<WorkeLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // agora vou instânciar as entidades department worker 

            Department dept = new Department(deptName);

            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine();
            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.Write($"Enter #{i} contract data dd/mm/yyyy: ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);

                // chamo o metodo adicionar contrato

                worker.AddContract(contract);

            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            Console.WriteLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
           // Console.WriteLine(month);
            int year = int.Parse(monthAndYear.Substring(3));
            //Console.WriteLine(year);
            Console.WriteLine("Name "+worker.Name);
            Console.WriteLine("Department: "+worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + " : " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));



















        }
    }
}
