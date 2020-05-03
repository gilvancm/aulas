using System;
using System.Collections.Generic;
using System.Text;

namespace Aula136ap.Entities
{
    abstract class TaxPayer
    {
        public String Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayer()
        {
        }

        public TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
    }
}
