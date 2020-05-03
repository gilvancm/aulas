using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Aula144ap.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public string UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            // recortei acondição pra qui retoranando o valor nule depois de pronto atraavez de string
            if (checkIn < CheckIn || checkOut < CheckOut)
            {
                return "Error in reservation: Reservation dates for update must be future dates: ";
            }
            else if (checkOut <= checkIn)
            {
                return "Error in reservation: Check-out date must be after check-in date ";
            }

            CheckIn = checkIn;
            CheckOut = checkOut;

            return null;
        }

        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights.";



        }
    }
}
