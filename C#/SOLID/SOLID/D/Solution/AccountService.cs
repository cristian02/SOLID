using Solid.Abstractions;
using Solid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D.Solution
{
    internal class AccountService
    {
        public ILog log;

        public AccountService(ISendEmail sendEmail, IAccountStorage accountStorage, ILog log)
        {
            this.log = log;
        }

        public void AddNewAccount(Account account)
        {
            this.log.WriteLog("");
        }
    }
}
