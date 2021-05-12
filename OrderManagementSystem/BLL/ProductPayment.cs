using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem.BLL
{
    public class ProductPayment :PaymentService<ProductPaymentModel>
    {
        protected override bool MakePayment(ProductPaymentModel model)
        {
            //todo logic
            return true;
        }
    }
}
