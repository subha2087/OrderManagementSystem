using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    public interface IMemberService
    {
        bool Activate();

        bool Upgrade(Int32 memberId);
    }
}
