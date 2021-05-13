using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem.BLL
{
    public class VideoPayment :PaymentService<VideoPaymentModel>
    {
        protected override bool MakePayment(VideoPaymentModel model)
        {
            //todo logic
            return true;
        }
    }
}
