using System;
using System.Globalization;
using Aula142ap.Entities;

namespace Aula142ap
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime nowi = DateTime.Now;
            Console.WriteLine("Exemoplo 1-3 é ruim, funciona mais não aconselho");
            Console.WriteLine("Resolvido Gilvan! Este exercicio exemplo deu certo mais tem muito if e não delega pra funçoes ou metodos");
            Console.WriteLine("Professo não aconselha fica lento e muito cheio de condicional no programa principal");
            Console.WriteLine(nowi);
            Console.WriteLine();
            Console.Write("Room number: " );
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
                // a codição diz que so pode a data maior que a de hoje
                //if (checkIn < now || checkOut < now)

                if (checkIn < reservation.CheckIn || checkOut < reservation.CheckOut)
                {
                    Console.WriteLine("Error in reservation: Reservation dates for update must be future dates: ");
                }
                else if(checkOut <= checkIn)
                {
                   Console.WriteLine("Error in reservation: Check-out date must be after check-in date ");
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
