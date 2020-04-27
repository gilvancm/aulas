using System;
using System.Globalization;
using Aula129ap.Entities;

namespace Aula129ap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo 3 sacando + taxa na conta superclasse onde a subclasse herda mais qualquer coisa : ");
            Console.WriteLine("sobreposição / subscrita  usa na função superclasse a prefix virtual e na subclasse override");
            Console.WriteLine("usando base pra Herda da Superclasse os atributos ");
            Console.WriteLine();
            /*
              Em Programação Orientada a Objetos, polimorfismo é recurso que permite
              que variáveis de um mesmo tipo mais genérico possam apontar para objetos
              de tipos específicos diferentes, tendo assim comportamentos diferentes
              conforme cada tipo específico.
              
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);
            
            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);
            
            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

            */
            Console.WriteLine("Polimofismo e que mostramos abaixo criando ");
            Console.WriteLine("3 variaveis comum do mesmo tipo, recebendo valores diferente criando 3 objetos na memoria com valores diferentes");
            Console.WriteLine(" com metodos com resultados indepentes ou diferentes ");
            Console.WriteLine();
            Account acc1 = new Account(1001, "Gilvan", 200.0);
            BusinessAccount acc2 = new BusinessAccount(1002, "Lucas", 200.00, 500.0);
            SavingsAccount acc3 = new SavingsAccount(1003, "Matheus", 200.0, 0.01);
            Console.WriteLine("na superclasse usa no metodo o prefixo virtual");
            Console.WriteLine("Saldo Account : " + acc1.Balance.ToString("F2", CultureInfo.InvariantCulture));
            acc1.Withdraw(10.0);
            Console.WriteLine("Saldo atualizado: " + acc1.Balance.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            Console.WriteLine("na subclasse usa no metodo o prefixo override + base ele herda da superclasse desconta 2.00");
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
