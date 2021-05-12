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
            BookPayment payment = new BookPayment();
            BookPaymentModel bookPaymentModel = new BookPaymentModel();
            IPackingService packingService = new PackingService();
            bool isDuplicateSlipGenerated = false;
            int id = 1;
            bool expected = true;
            //Act
            if(payment.MakePayment<BookPaymentModel>(bookPaymentModel))
            {
                isDuplicateSlipGenerated = packingService.GenerateDuplicateSlip();
            }
            //Assert
            Assert.AreEqual(expected, isDuplicateSlipGenerated);
        }
    }
}
