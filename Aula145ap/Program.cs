using System;
using System.Globalization;
using Aula145ap.Entities;
using Aula145ap.Entities.Exceptions;

namespace Aula145ap
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            Console.WriteLine("Resolvido por Gilvan! ");
            Console.WriteLine();
            Console.WriteLine("Enter account data: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           
            Console.Write("Withdraw limit: ");
            double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account acc = new Account(number, holder, withDrawLimit);
            acc.Deposit(amount);
            
            Console.WriteLine(acc);
            Console.WriteLine();
            
            Console.Write("Enter amount for withdraw: ");
            amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            acc.withDraw(amount);
            Console.WriteLine("New balance: " + acc);
           
            }
            catch (DomainException e)
            {
                Console.WriteLine("Alert :"+e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("alert of format:"+ e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception generic: "+e.Message);
            }

            
        }

        
    }
}
