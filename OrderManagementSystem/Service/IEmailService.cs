using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    public interface IEmailService
    {
        bool SendEmail(string emailId,int templateId);
    }
}
