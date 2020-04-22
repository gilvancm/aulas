using System;
using System.Text;
using System.Globalization;
using Aula126bp.Entities;

namespace Aula126bp
{
    class Program
    {
        static void Main(string[] args)
        {
            // criamos 2 objetos do tipo Account e BusinessAccont
            // os argumentos
            Account acc = new Account(1001, "Gilvan", 0.0);
            BusinessAccont bacc = new BusinessAccont(1002, "Lucas", 0.0, 500.0);
           
           
            Console.WriteLine("UPCASTING, que é conversão da subclasse pra superclasse");
            // Casting é converter tipo de variáveis representa em ()

            // a variavel Account recebe um objeto BusinessAccont

            Account acc1 = bacc;
            Account acc2 = new BusinessAccont(1003, "Matheus", 100.00, 500.00);
            Account acc3 = new SavingsAccount(1004, "Sandra", 50.0, 0.01);
            
             Console.WriteLine("DOWNCASTING, que é conversão da superclasse pra subclasse");
             Console.WriteLine("Exemplo 1 ");
             // BusinessAccont acc4 = acc2 ele mostra erro na conversão
             // vmos ter de converte()    Account em BusinessAccount
             BusinessAccont acc4 = (BusinessAccont)acc2;
             // agora posso fazer a chamada do empretimo
             acc4.Loan(100.0);
             // se eu tentar de outro jeito abaixo ele não vai mostrar o loan
             // acc2.
             Console.WriteLine("Exemplo 2 ");

             //ele mostra erro
             //BusinessAccont acc5 = acc3;
             // mesmo que eu converta com casting ele mostra sem erro
             //mais quando copilo ele mostra o erro
             //  BusinessAccont acc5 = (BusinessAccont)acc3;
             // lembre que os objetos pode ser de tipo diferente

             // temos que fazer uma tratativa
             // vamos usaar o operador is e depois as
             //testo abaixo se a varivavel acc3 é uam instancai de BusinessAccont

            if(acc3 is BusinessAccont)
            {
                // a conversão pode ser de 2 maneiras ou referência
                // BusinessAccont acc5 = (BusinessAccont)acc3;
                BusinessAccont acc5 = acc3 as BusinessAccont;

                acc5.Loan(200.0);
                Console.WriteLine("Loan");

            }

            if(acc3 is SavingsAccount)
            {
                // a conversão pode ser de 2 maneiras
                // SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalence();
                Console.WriteLine("Update!");
            } 

        }
    }
}
