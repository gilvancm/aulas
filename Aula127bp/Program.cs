using System;
using Aula127bp.Entities;
using System.Globalization;
namespace Aula127bp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo 2 sacando + taxa na conta superclasse e sem na subclasse : ");
            Console.WriteLine("sobreposição / subscrita  usa na função superclasse a prefix virtual e na subclasse override");
            
            Console.WriteLine();
            Account acc1 = new Account(1001, "Gilvan", 200.0);
            BusinessAccount acc2 = new BusinessAccount(1002, "Lucas", 200.00, 500.0);
            SavingsAccount acc3 = new SavingsAccount(1003, "Matheus", 200.0, 0.01);
            Console.WriteLine("na superclasse usa no metodo o prefixo virtual");
            Console.WriteLine("Saldo Account : " + acc1.Balance.ToString("F2", CultureInfo.InvariantCulture));
            acc1.Withdraw(10.0);
            Console.WriteLine("Saldo atualizado: " + acc1.Balance.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            Console.WriteLine("Saldo BusinessAccount : " + acc2.Balance.ToString("F2", CultureInfo.InvariantCulture));
            acc2.Withdraw(10.0);
            Console.WriteLine("Saldo atualizado: " + acc2.Balance.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            Console.WriteLine("na subclasse usa no metodo o prefixo override");
            Console.WriteLine("Saldo SavingsAccount : " + acc3.Balance.ToString("F2", CultureInfo.InvariantCulture));
            acc3.Withdraw(10.0);
            Console.WriteLine("Saldo atualizado: " + acc3.Balance.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
        }
    }
 }


