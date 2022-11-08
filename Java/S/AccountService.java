package S;

import Entitites.Account;

class AccountService
{
    private final String ERROR = "Error"; 
    private final String SUCCESS = "Success"; 

    //Create the new account
    public void AddNewAccount(Account account)
    {
        try{
            this.InsertAccount(account);
            this.SendEmail(account);
            this.WriteLog(ERROR, null);
        }catch(Exception ex)
        {
            WriteLog(ERROR, ex);
        }
    }

    //Insert new account in db 
    private void InsertAccount(Account account)
    {

    }

    //Write log 
    private void WriteLog(String msg, Exception ex)
    {

    }

    //Send email with the process result 
    private void SendEmail(Account account)
    {

    }
}