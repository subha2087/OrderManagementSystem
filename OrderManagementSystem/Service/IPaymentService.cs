using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    interface IPaymentService
    {
        bool MakePayment<T>(T model) where T : IPaymentModel;
    }
}
