using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem.BLL
{
    public class MembershipPayment :PaymentService<MembershipPaymentModel>
    {
        protected override bool MakePayment(MembershipPaymentModel model)
        {
            //todo logic
            return true;
        }
    }
}
