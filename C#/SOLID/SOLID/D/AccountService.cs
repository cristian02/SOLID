using Solid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D
{
    internal class AccountService
    {
        public readonly Log log; 
        public AccountService(Log log) => this.log = log;

        public void AddNewAccount(Account account)
        {
            log.WriteLog("The account was successfully created");
        }
    }
}
