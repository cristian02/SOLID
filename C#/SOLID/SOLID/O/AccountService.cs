using Solid.Models;

namespace SOLID.O;
/// <summary>
/// What happen if you need to include one more account type 
/// </summary>
internal class AccountService
{
    public void CreateAccount(Account account)
    {
        switch (account.accountType)
        {
            case AccountType.CertificateOfDeposit:
                CreateCertificateOfDeposit(account);
                break;
            case AccountType.BrokerageAccount:
                CreateBrokerageAccount(account);
                break;
            case AccountType.IndividualRetirementArrangement:
                CreateIndividualRetirementArrangement(account);
                break;
            case AccountType.MoneyMarketAccount:
                CreateMoneyMarketAccount(account);
                break;
            case AccountType.SavingsAccount:
                CreateSavingsAccount(account);
                break;
            case AccountType.CheckingAccount:
                CreateCheckingAccount(account);
                break;  
        }
    }


    private void CreateCertificateOfDeposit(Account account) { }
    private void CreateBrokerageAccount(Account account) { }
    private void CreateIndividualRetirementArrangement(Account account) { }
    private void CreateMoneyMarketAccount(Account account) { }
    private void CreateSavingsAccount(Account account) { }
    private void CreateCheckingAccount(Account account) { }

}
