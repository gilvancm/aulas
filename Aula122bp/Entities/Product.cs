using System;
using System.Collections.Generic;
using System.Text;
using Aula122bp.Entities;
using System.Globalization;

namespace Aula122bp.Entities
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
    }
}
