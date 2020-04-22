using System;
using System.Collections.Generic;
using System.Text;
using Aula122ap.Entities;
using System.Globalization;

namespace Aula122ap.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }


        public override string ToString()

        {

            return 
                "Product : "
                +Product.Name+
                ", Price: "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: "
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
