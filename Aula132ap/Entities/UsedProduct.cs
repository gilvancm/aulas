using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Aula132ap.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            :base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override double PriceTag()
        {
            return base.PriceTag();
        }

        public override string ToString()
        {
            return "Name: " + Name + ",( Used ), Price $: " + Price.ToString("F2", CultureInfo.InvariantCulture) + " Manufacture date: "+ManufactureDate.ToString("dd/MM/yyyy");
        }
    }
}
