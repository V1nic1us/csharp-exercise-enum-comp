using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exercise_enum_comp.Entities.Enums
{
    internal enum OrderStatus: int
    {
        PEDING_PAYMENT = 0,
        PROCESSING = 1,
        SHIPPED = 2,
        DELIVERED = 3,
    }
}
