using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.I
{
    internal class SendNotification : INotification
    {
        public void SendEmail()
        {
            throw new NotImplementedException();
        }

        public void SendPhone()
        {
            throw new NotImplementedException();
        }

        public void SendSms(string phone)
        {
            throw new NotImplementedException();
        }
    }
}
