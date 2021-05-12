using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OrderManagementSystemTest
{
    [TestClass]
    public class ProductPaymentTest
    {
        [TestMethod]
        public void MakePayment(ProductPaymentModel productPaymentModel)
        {
            bool isPaymentSlipGenerated = false;
            bool expected = true;
            if(PaymentSuccess)
            {
                isPaymentSlipGenerated=GeneratePaymentSlip();
            }
            Assert.AreEqual(expected, isPaymentSlipGenerated);
        }
    }
}
