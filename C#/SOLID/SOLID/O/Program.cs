using Solid.Models;
using SOLID.O;

new AccountService().CreateAccount(new Account()
{
    accountType = AccountType.MoneyMarketAccount, 
    email = String.Empty, 
    name = String.Empty
});