using System;
using System.Collections.Generic;
using System.Text;
using Aula130ap.Entities;
using System.Globalization;
namespace Aula130ap.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }


        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);

        }


        public void RemoveEmployee(Employee employee)
        {
            Employees.Remove(employee);

        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
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

                                               
            return sb.ToString();

        }


    }
}
