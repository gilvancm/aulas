using System;
using System.Globalization;
using Aula144ap.Entities;
using Aula144ap.Entities.Exceptions;

namespace Aula144ap
{
    class Program
    {
        static void Main(string[] args)
        {
            // senaario try onde testa catch onde captura o Exception
            try
            { 
             DateTime nowi = DateTime.Now;
             Console.WriteLine("BOAS PRATICAS");
             Console.WriteLine("Exemplo 1-3 é o melhor que o anterior, é o certo codigo mais enxuto e delega a cada parte");
             Console.WriteLine("Resolvido Gilvan! Este exercicio exemplo deu certo mais tem muito if e não delega pra funçoes ou metodos");
             Console.WriteLine("Professo aconselha este codido fica enxuto o programa principal e maiss rapido aplicação");
             Console.WriteLine(nowi);
             Console.WriteLine();
             Console.Write("Room number: ");
             int roomNumber = int.Parse(Console.ReadLine());
             Console.Write("Check-in date (dd/MM/yyyy): ");
             DateTime checkIn = DateTime.Parse(Console.ReadLine());
             Console.Write("Check-out date (dd/MM/yyyy): ");
             DateTime checkOut = DateTime.Parse(Console.ReadLine());

            
             Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);

             Console.WriteLine("Reservation: " + reservation);
             Console.WriteLine();
                         
             Console.WriteLine("---------------------------------------------");
             Console.WriteLine(nowi);
             Console.WriteLine("Enter data to update the reservation:");
             Console.Write("Check-in date (dd/MM/yyyy): ");
             checkIn = DateTime.Parse(Console.ReadLine());
             Console.Write("Check-out date (dd/MM/yyyy): ");
             checkOut = DateTime.Parse(Console.ReadLine());
            
             DateTime now = DateTime.Now;
             Console.WriteLine(now.ToString("dd/MM/yyyy"));                
           
             reservation.UpdateDates(checkIn, checkOut);

             Console.WriteLine("Reservation: " + reservation);

            }
            catch (DomainException e)
            {
                Console.WriteLine("Error personalizados da aplicação nas funções e construtor"+e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error generico com tratamento digitou letra no lugar de número :"+e.Message);
            }
            
             catch (Exception e)  // esse é um tratamento generico residente no .net
             {
                 Console.WriteLine("Error padrão do csharp Generica "+e.Message);
             }
             
            Console.ReadLine();
        }
    }
}
