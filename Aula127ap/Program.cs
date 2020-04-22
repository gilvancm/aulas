using System;
using Aula127ap.Entities;
using System.Globalization;

namespace Aula127ap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo 1 sacando sem taxa: ");

            Account acc1 = new Account(1001, "Gilvan", 200.0);
            BusinessAccount acc2 = new BusinessAccount(1002, "Lucas", 200.00, 500.0);
            SavingsAccount acc3 = new SavingsAccount(1003, "Matheus", 200.0, 0.01);
           
            Console.WriteLine("Saldo Account : "+acc1.Balance.ToString("F2", CultureInfo.InvariantCulture));
            acc1.Withdraw(10.0);
            Console.WriteLine("Saldo atualizado: " + acc1.Balance.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            Console.WriteLine("Saldo BusinessAccount : " + acc2.Balance.ToString("F2", CultureInfo.InvariantCulture));
            acc2.Withdraw(10.0);
            Console.WriteLine("Saldo atualizado: " + acc2.Balance.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            Console.WriteLine("Saldo SavingsAccount : " + acc3.Balance.ToString("F2", CultureInfo.InvariantCulture));
            acc3.Withdraw(10.0);
            Console.WriteLine("Saldo atualizado: "+acc3.Balance.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
        }
    }
}
