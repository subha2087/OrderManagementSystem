using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManagementSystem;
using OrderManagementSystem.BLL;

namespace OrderManagementSystemTest
{
    [TestClass]
    public class ProductPaymentTest
    {
        [TestMethod]
        public void MakePayment()
        {
            ProductPayment payment = new ProductPayment();
            ProductPaymentModel productPaymentModel = new ProductPaymentModel();
            IPackingService packingService = new PackingService();
            bool isPaymentSlipGenerated = false;
            bool expected = true;
            if(payment.MakePayment<ProductPaymentModel>(productPaymentModel))
            {
                isPaymentSlipGenerated= packingService.GeneratePaymentSlip();
            }
            Assert.AreEqual(expected, isPaymentSlipGenerated);
        }
    }
}
