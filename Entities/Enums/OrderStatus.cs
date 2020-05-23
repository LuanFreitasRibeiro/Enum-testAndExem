using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_9.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 34
    }
}
