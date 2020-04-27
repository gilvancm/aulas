using System;
using System.Collections.Generic;
using System.Text;
using Aula130bp.Entities;

namespace Aula130bp.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }



        public OutsourcedEmployee()

        {

        }



        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)

            : base(name, hours, valuePerHour)

        {

            AdditionalCharge = additionalCharge;

        }



        public override double Payment()

        {

            return base.Payment() + 1.1 * AdditionalCharge;

        }
    }
}
