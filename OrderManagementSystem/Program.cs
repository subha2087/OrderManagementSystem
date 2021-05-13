using OrderManagementSystem.BLL;
using System;

namespace OrderManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sample implementation for Payment
            ProductPaymentModel model = new ProductPaymentModel();
            //To be replaced with dependancy Injection in startup 
            ProductPayment productPayment = new ProductPayment(new PackingService());
            productPayment.MakePayment<ProductPaymentModel>(model);


            BookPaymentModel bpmodel = new BookPaymentModel();
            //To be replaced with dependancy Injection in startup 
            BookPayment bookPayment = new BookPayment(new PackingService());
            bookPayment.MakePayment<BookPaymentModel>(bpmodel);

        }
    }
}
