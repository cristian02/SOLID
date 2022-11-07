namespace Solid.Models
{
    public class Account
    {
        public AccountType accountType { get; set; }

        public string email { get; set; }

        public string name { get; set; }
    }

    public enum AccountType
    {
        CheckingAccount, 
        SavingsAccount, 
        MoneyMarketAccount, 
        CertificateOfDeposit, 
        IndividualRetirementArrangement, 
        BrokerageAccount
    }
}
