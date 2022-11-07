using Solid.Abstractions;
using Solid.Models;

namespace SOLID.S.Solution;
public class AccountService
{
    public ISendEmail sendEmail;
    public IAccountStorage accountStorage;
    public ILog log;
    private readonly string ERRROR = "Error";
    private readonly string SUCCESS = "Success";

    public AccountService(ISendEmail sendEmail, IAccountStorage accountStorage, ILog log)
    {
        this.sendEmail = sendEmail;
        this.accountStorage = accountStorage;
        this.log = log;
    }

    /// <summary>
    /// Create the new account
    /// </summary>
    /// <param name="account"></param>
    public void AddNewAccount(Account account)
    {
        try
        {
            this.accountStorage.InsertAccount(account);
            this.sendEmail.SendEmail(account);
            this.log.WriteLog(SUCCESS, null);
        }
        catch (Exception ex)
        {
            this.log.WriteLog(ERRROR, ex);
        }
    }
}
