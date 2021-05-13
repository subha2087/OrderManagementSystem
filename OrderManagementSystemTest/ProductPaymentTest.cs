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
            ProductPayment payment = new ProductPayment(new PackingService());
            ProductPaymentModel productPaymentModel = new ProductPaymentModel();
            bool isPaymentSlipGenerated = false;
            bool expected = true;
            isPaymentSlipGenerated = payment.MakePayment<ProductPaymentModel>(productPaymentModel);
            Assert.AreEqual(expected, isPaymentSlipGenerated);
        }

        [TestMethod]
        public void CommisionUponMakePayment()
        {
            ProductPayment payment = new ProductPayment(new PackingService());
            ProductPaymentModel productPaymentModel = new ProductPaymentModel();
            bool actual = false;
            bool expected = true;
            if (payment.MakePayment<ProductPaymentModel>(productPaymentModel))
            {
                actual = payment.MakeCommisionPayment<ProductPaymentModel>(productPaymentModel);
            }
            Assert.AreEqual(expected, actual);
        }
    }
}
