using System;
using System.Collections.Generic;
using System.Text;
using Aula122bp.Entities;

namespace Aula122bp.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0,

        Processing = 1,

        Shipped = 2,

        Delivered = 3
    }
}
