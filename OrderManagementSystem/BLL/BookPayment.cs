using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem.BLL
{
    public class BookPayment :PaymentService<BookPaymentModel>
    {
        private IPackingService _packingServce;
        public BookPayment(IPackingService packingService)
        {
            _packingServce = packingService;
        }
        protected override bool MakePayment(BookPaymentModel model)
        {
            //todo logic process payment
            //If payment success
            _packingServce.GenerateDuplicateSlip(model.PackingId);
            return true;
        }
    }
}
