using System;
using System.Collections.Generic;
using System.Text;
using Aula136ap.Entities;


namespace Aula136ap.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(double healthExpenditures, string name, double anualIncome)
          : base(name,anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome >= 50000.00 && HealthExpenditures > 0.00)
            {
                return ((AnualIncome * 0.25) - (HealthExpenditures * 0.50));
            }
            
                       
            if (AnualIncome < 20000.00 && HealthExpenditures >= 0.00)
            {
               return AnualIncome * 0.15;

            }

            if (AnualIncome >= 20000.00 && HealthExpenditures >= 0.00)
            {
                return AnualIncome * 0.25;

            }
            
               return 0.0;
           
        }
    }
}
