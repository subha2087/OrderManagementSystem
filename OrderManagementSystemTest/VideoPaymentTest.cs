using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManagementSystem;
using OrderManagementSystem.BLL;

namespace OrderManagementSystemTest
{
    [TestClass]
    public class VideoPaymentTest
    {
        [TestMethod]
        public void MakePayment()
        {
            VideoPayment payment = new VideoPayment();
            VideoPaymentModel videoPaymentModel = new VideoPaymentModel();
            IVideoService videoService = new VideoService();
            bool actual = false;
            bool expected = true;
            if(payment.MakePayment<VideoPaymentModel>(videoPaymentModel))
            {
                actual= videoService.AddFreeVideo();
            }
            Assert.AreEqual(expected, actual);
        }
    }
}
