using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Aula132ap.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual double PriceTag()
        {
            return Price;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Price: " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
