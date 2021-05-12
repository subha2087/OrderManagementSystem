using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    public interface IPackingService
    {
        bool GeneratePaymentSlip();

        bool GenerateDuplicateSlip(Int32 id);
    }
}
