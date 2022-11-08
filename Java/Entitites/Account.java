package Entitites;

public class Account {
    private AccountType accountType;
    private String email; 
    private String name; 

    public AccountType GetAccountType()
    {
        return accountType; 
    }

    public void SetAccountType(AccountType accountType)
    {
        this.accountType = accountType; 
    } 

    public String GetEmail(){
        return email; 
    }

    public void SetEmail(String email){
        this.email = email; 
    }

    public String GetName() {
        return name; 
    }

    public void SetName(String name)
    {
        this.name = name; 
    }
}
