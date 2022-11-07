using Solid.Business.AccountTypes;
using Solid.Models;

namespace SOLID.O.Solution;
class Program
{
    static void main()
    {
        AccountService accountService = new AccountService(new CreateSavingsAccount());
        accountService.CreateAccount(new Account()
        {
            email = String.Empty,
            name = String.Empty
        });
    }
}

