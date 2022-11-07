using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.I
{
    internal interface INotification
    {
        void SendEmail();
        void SendPhone();
        void SendSms(string phone);

    }
}
