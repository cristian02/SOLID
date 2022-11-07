using Solid.Abstractions;
using Solid.Models;

namespace SOLID.O.Solution;
public class AccountService
{
    private readonly ICreateAccount createAccount;

    public AccountService(ICreateAccount createAccount)
    {
        this.createAccount = createAccount;
    }

    public void CreateAccount(Account account)
    {
        this.createAccount.CreateAccount(account);
    }
}
