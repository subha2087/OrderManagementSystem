using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    public class EmailService : IEmailService
    {
        public bool SendEmail(string emailId, int templateId)
        {
            //todo logic for sending email
            return true;
        }
    }
}
