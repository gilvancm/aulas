using System;
using Aula133ap.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Aula133ap
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Class abstract exemplo 1 na class generalizada(superclasse) ");
           // Account acc1 = new Account(1001, " Alex ", 500.0);
            Account acc2 = new SavingsAccount(1002, "gilvan", 500.00, 0.01);

          //  acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            //Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
