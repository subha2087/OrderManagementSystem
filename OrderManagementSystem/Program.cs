using OrderManagementSystem.BLL;
using System;

namespace OrderManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //To be replaced with dependancy Injection in startup 
            ProductPayment productPayment = new ProductPayment(new PackingService());
            ProductPaymentModel model = new ProductPaymentModel();
            productPayment.MakePayment<ProductPaymentModel>(model);

            //To be replaced with dependancy Injection in startup 
            BookPayment bookPayment = new BookPayment(new PackingService());
            BookPaymentModel bpmodel = new BookPaymentModel();
            bookPayment.MakePayment<BookPaymentModel>(bpmodel);

        }
    }
}
