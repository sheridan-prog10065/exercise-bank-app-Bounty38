namespace BankApp;
public class Bank
{
     #region Field Variables
    private List<Account> _accountList;
    #endregion

    
    #region Constructor
    public Bank()
    {
        _accountList = new List<Account>();
    }
    #endregion
    
    
    #region Methods
    public Account OpenAccount()
    {
        return null;
    }

    public void LoadAccountData()
    {
        
    }

    public void SaveAccountData()
    {
        
    }

    public Account FindAccount(int acctNum)
    {
        return null;
        
    }

    private void CreateDefaultAccounts()
    {
        
    }

    private int DetermineAccountNumber()
    {
        return 0;
    }
    #endregion
}