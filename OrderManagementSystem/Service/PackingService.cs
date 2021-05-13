using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    public class PackingService : IPackingService
    {
        public bool GenerateDuplicateSlip(int id)
        {
            //ToDo
            //logic
            Console.WriteLine("Duplicate Payment Slip Generated");
            return true;
        }

        public bool GeneratePaymentSlip()
        {
            //Todo
            //Code for Generating slip
            Console.WriteLine("Payment Slip Generated");
            return true;
        }
    }
}
