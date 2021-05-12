using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem.BLL
{
    public class BookPayment :PaymentService<BookPaymentModel>
    {
        protected override bool MakePayment(BookPaymentModel model)
        {
            //todo logic
            return true;
        }
    }
}
