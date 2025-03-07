namespace BankApp;
public class SavingsAccount : Account
{
    #region Constructor
    public SavingsAccount(string acctHolderName, int acctNo) : base(acctHolderName, acctNo)
    {
        
    }

    public double AnnualInterestRate
    {
        get { return base.AnnualInterestRate; }
        set { base.AnnualInterestRate = value; }
    }

    public override decimal Deposit(decimal amount)
    {
        return 0;
    }
}