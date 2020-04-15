using System;
using System.Collections.Generic;
using System.Text;

namespace Aula119ap.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePercHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuePercHour, int hours)
        {
            Date = date;
            ValuePercHour = valuePercHour;
            Hours = hours;
        }

        public double totalValue()
        {
            return Hours * ValuePercHour;
        }


    }
}
