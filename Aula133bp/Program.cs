using System;
using Aula133bp.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Aula133bp
{
    class Program
    {
        static void Main(string[] args)
        {
            //feito pelo professor
            Console.WriteLine("vou criar uma lista generalizada, pode instânciar sem problema");

            List<Account> list = new List<Account>();
            //podemos instanciar e adicionar na lista
            list.Add(new BusinessAccount(1001, "Gilvan", 500.00, 400.00));
            list.Add(new SavingsAccount(1002, "lucas", 500.00, 0.01));
            list.Add(new BusinessAccount(1003, "matheus", 500.00, 400.00));
            list.Add(new SavingsAccount(1004, "sandra", 500.00, 0.01));

            // mostrando o saldo da contas
            double sum = 0.00;

            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }
            Console.WriteLine("Balance: "+sum.ToString("F2", CultureInfo.InvariantCulture));

            //executar um saque em cada conta onde é o polomosfimo

            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);

            }
            // podemos fazer chamada polifomicas sem problema
           foreach (Account acc in list)
            {
                Console.WriteLine("Account:"+acc.Number+" : Updated Balance for Account: "+acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.WriteLine();

            foreach (Account acc in list)
            {
                Console.WriteLine("Account :"+acc.Number+ ", Holder: "+acc.Holder+", Balance: "+acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }




        }
    }
  
}
