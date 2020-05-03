using System;
using System.Collections.Generic;
using System.Text;

namespace Aula136bp.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }

        public double AnualIncome { get; set; }



        public TaxPayer()
        {

        }



        protected TaxPayer(string name, double anualIncome)
        {

            Name = name;

            AnualIncome = anualIncome;

        }



        public abstract double Tax();
    }
}
