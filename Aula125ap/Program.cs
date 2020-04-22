using System;
using Aula125ap.Entities;

namespace Aula125ap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("faça um depoisito ! ");

            BusinessAccont account = new BusinessAccont(2536, "gilvan", 250.0, 300.0);

            Console.WriteLine(account.Balance);

          //  account.Balance = 200.0; este atributo não pode receber valor


        }
    }
}
