using System;
using System.Collections.Generic;
using System.Text;
using Aula115ap.Entities.Enums;

namespace Aula115ap.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return  Id +
                   " , "
                   + Moment +
                   ","
                   + Status;

        }
    }
}
