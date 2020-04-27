using System;
using System.Collections.Generic;
using System.Text;
using Aula130ap.Entities;
using System.Globalization;

namespace Aula130ap.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name,hours,valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public void AddOutsourcedEmployee(OutsourcedEmployee employee)
        {
            Employees.Add(employee);

        }

        public void RemoveOutsourcedEmployee(OutsourcedEmployee employee)
        {
            Employees.Remove(employee);

        }



        public override double Payment()
        {
            return base.Payment()
             + 1.1 * AdditionalCharge;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Name: ");
            sb.AppendLine(Name);
            sb.Append("Hours: ");
            sb.AppendLine(Hours.ToString());
            sb.Append("ValuePerHou: ");
            sb.AppendLine(ValuePerHour.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append("Payment: ");
            sb.AppendLine(Payment().ToString("F2", CultureInfo.InvariantCulture));
            sb.Append("AdditionalCharge: ");
            sb.AppendLine(AdditionalCharge.ToString("F2", CultureInfo.InvariantCulture));


            return sb.ToString();

        }

    }
}
