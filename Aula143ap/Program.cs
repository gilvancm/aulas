using System;
using System.Globalization;
using Aula143ap.Entities;

namespace Aula143ap
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime nowi = DateTime.Now;
            Console.WriteLine("Exemoplo 1-2 é ruim melhor que o anterior, funciona mais não aconselho");
            Console.WriteLine("Resolvido Gilvan! Este exercicio exemplo deu certo mais tem muito if e não delega pra funçoes ou metodos");
            Console.WriteLine("Professo não aconselha fica lento e muito cheio de condicional no programa principal");
            Console.WriteLine(nowi);
            Console.WriteLine();
            Console.Write("Room number: ");
            int roomNumber = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservation: Check-out date must be after check-in date ");

            }
            else
            {
                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);

                Console.WriteLine("Reservation: " + reservation);
                Console.WriteLine();

                // atualização da reserva
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine(nowi);
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;

                Console.WriteLine(now.ToString("dd/MM/yyyy"));
               //fazemos essa tratitva abaixo trazendo da função ou metodo

                string error = reservation.UpdateDates(checkIn, checkOut);

                if (error != null)
                {
                    Console.WriteLine("Error in reservation: "+error);

                }

                else
                {
                    reservation.UpdateDates(checkIn, checkOut);

                    Console.WriteLine("Reservation: " + reservation);
                }

            }
        }
    }
}
