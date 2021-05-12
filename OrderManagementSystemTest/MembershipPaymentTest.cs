using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManagementSystem;
using OrderManagementSystem.BLL;

namespace OrderManagementSystemTest
{
    [TestClass]
    public class MembershipPaymentTest
    {
        [TestMethod]
        public void MakePayment()
        {
            MembershipPayment payment = new MembershipPayment();
            MembershipPaymentModel membershipPaymentModel = new MembershipPaymentModel();
            IMemberService memberService = new MemberService();
            bool actual = false;
            bool expected = true;
            int memberId = 1;
            if(payment.MakePayment<MembershipPaymentModel>(membershipPaymentModel))
            {
                actual= membershipPaymentModel.Activate==true? memberService.Activate():memberService.Upgrade(memberId);
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SendEmailUponMakePayment()
        {
            MembershipPayment payment = new MembershipPayment();
            MembershipPaymentModel membershipPaymentModel = new MembershipPaymentModel();
            IMemberService memberService = new MemberService();
            IEmailService emailService = new EmailService();
            bool actual = false;
            bool expected = true;
            string emailId = "";
            int templateId = 1; //1 for Activation, 2 for Upgrade 
            if (payment.MakePayment<MembershipPaymentModel>(membershipPaymentModel))
            {
                actual = emailService.SendEmail(emailId,templateId);
            }
            Assert.AreEqual(expected, actual);
        }
    }
}
