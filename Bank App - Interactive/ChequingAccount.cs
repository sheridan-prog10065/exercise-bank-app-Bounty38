namespace BankApp;
public class ChequingAccount : Account
{
    public ChequingAccount(string acctHolderName, int acctNo) : base(acctHolderName, acctNo)
    {

    }

    public double AnnualInterestRate
    {
        get { return base.AnnualInterestRate; }
        set { base.AnnualInterestRate = value; }
    }

    public override decimal Withdraw(decimal amount)
    {
        return 0;
    }
}