using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Aula132ap.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee)
            :base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override double PriceTag()
        {
            return base.PriceTag() + CustomsFee;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Price $: " + PriceTag().ToString("F2", CultureInfo.InvariantCulture)+ " CustomsFree $: "+CustomsFee.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
