using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionExercise3.Entities.Enums
{
    internal enum OrderStatus : int
    {
        PENDING_PAYMENT,
        PROCESSING,
        SHIPPED,
        DELIVERED
    }
}
