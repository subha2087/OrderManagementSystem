using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    public abstract class PaymentService<TModel> : IPaymentService
     where TModel : IPaymentModel
    {
        public bool MakePayment<T>(T model) where T : IPaymentModel
        {
           return MakePayment((TModel)(object)model);
        }

        protected abstract bool MakePayment(TModel model);
    }
}
