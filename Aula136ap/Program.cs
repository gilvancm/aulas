using System;
using System.Collections;
using System.Collections.Generic;
using Aula136ap.Entities;
using System.Globalization;

namespace Aula136ap
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.WriteLine("Resolvido por Gilvan usando abstract no metodo");
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Individual or company (i/c)? ");
                char ic = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ic == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    if(anualIncome > 0.00)
                    {
                        list.Add(new Individual(healthExpenditures, name, anualIncome));

                    }


                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    list.Add(new Company(numberOfEmployees, name, anualIncome));
                }

            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            Console.WriteLine();
            foreach (TaxPayer tax in list)
            {
                Console.WriteLine("Name: " + tax.Name + ", $: " + tax.Tax().ToString("F2", CultureInfo.InvariantCulture));
                
            }

            Console.ReadLine();

        }
    }
}
