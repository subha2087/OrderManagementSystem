using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManagementSystem;
using OrderManagementSystem.BLL;

namespace OrderManagementSystemTest
{
    [TestClass]
    public class BookPaymentTest
    {
        [TestMethod]
        public void MakePayment()
        {
            //Prepare
            BookPayment payment = new BookPayment(new PackingService());
            BookPaymentModel bookPaymentModel = new BookPaymentModel();
            bool isDuplicateSlipGenerated = false;
            bool expected = true;
            //Act
            isDuplicateSlipGenerated = payment.MakePayment<BookPaymentModel>(bookPaymentModel);
           
            //Assert
            Assert.AreEqual(expected, isDuplicateSlipGenerated);
        }

        [TestMethod]
        public void CommisionUponMakePayment()
        {
            BookPayment payment = new BookPayment(new PackingService());
            BookPaymentModel bookPaymentModel = new BookPaymentModel();
            bool actual = false;
            bool expected = true;
            if (payment.MakePayment<BookPaymentModel>(bookPaymentModel))
            {
                actual = payment.MakeCommisionPayment<BookPaymentModel>(bookPaymentModel);
            }
            Assert.AreEqual(expected, actual);
        }
    }
}
