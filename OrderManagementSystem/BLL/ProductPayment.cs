using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem.BLL
{
    public class ProductPayment :PaymentService<ProductPaymentModel>
    {
        private IPackingService _packingServce;
        public ProductPayment(IPackingService packingService)
        {
            _packingServce = packingService;
        }
        protected override bool MakePayment(ProductPaymentModel model)
        {
            //todo logic process payment
            //If payment success
            _packingServce.GeneratePaymentSlip();
            return true;
        }
    }
}
