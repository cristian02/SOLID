using Solid.Models; 
namespace SOLID.S;
/// <summary>
/// This example shows that this class has a lot of responsabilities 
/// </summary>
internal class AccountService
{
    private readonly string ERRROR = "Error";
    private readonly string SUCCESS = "Success"; 

    /// <summary>
    /// Create the new account 
    /// </summary>
    /// <param name="account"></param>
    public void AddNewAccount(Account account)
    {
        try
        {
            this.InsertAccount(account);
            this.SendEmail(account);
            WriteLog(SUCCESS, null);
        }catch(Exception ex)
        {
            WriteLog(ERRROR, ex);
        }
    }

    /// <summary>
    /// Insert new account in db 
    /// </summary>
    /// <param name="account"></param>
    public void InsertAccount(Account account)
    {

    }

    /// <summary>
    /// Write Log 
    /// </summary>
    /// <param name="ex"></param>
    /// <param name="msg"></param>
    public void WriteLog(string? msg, Exception? ex = null)
    {

    }

    /// <summary>
    /// Send email with the process result
    /// </summary>
    /// <param name="account"></param>
    public void SendEmail(Account account)
    {

    }
}
