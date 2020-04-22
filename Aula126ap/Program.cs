using System;
using System.Text;
using System.Globalization;
using Aula126ap.Entities;

namespace Aula126ap
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine();
            Console.WriteLine("Exemplo 1 Account acc1");
                                       //os argumentos 
            Account acc1 = new Account(1001, "Gilvan", 100.0);
            Console.Write(acc1.Number);
            Console.Write(" , "+acc1.Holder);
            Console.Write(" , " + acc1.Balance);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Exemplo 2 Account acc2");
            Account acc2 = new BusinessAccont(1002, "Lucas", 150.00, 500.00);
            
            Console.Write(acc2.Number);
            Console.Write(" , " + acc2.Holder);
            Console.Write(" , " + acc2.Balance);
            // Console.WriteLine(" , " + acc2.); // obs que instaciamos mais não visualizamos pela superclasse LoanLimit

            Console.WriteLine();

           Account acc3 = new SavingsAccount(1003, "Matheus", 300.00, 0.01);
           
            Console.WriteLine();
            Console.WriteLine("Exemplo 3 Account acc3");

            Console.Write(acc3.Number);
            Console.Write(" , " + acc3.Holder);
            Console.Write(" , " + acc3.Balance);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Exemplo 4 SavingsAccount sac");

            SavingsAccount sac = new SavingsAccount(1004, "Sandra", 250.0, 0.01);
            
            Console.Write(sac.Number);
            Console.Write(" , " + sac.Holder);
            Console.Write(" , " + sac.Balance);
            Console.Write(" , " + sac.InterestRate);
            Console.WriteLine();

            // obs que instaciamos mais não visualisamos pela subclasse e visualizamos InterestRate





        }
    }
}
