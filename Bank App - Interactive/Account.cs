namespace BankApp;
/// <summary>
/// A class that represents the Account and represents the info of an Account"
/// </summary>
public class Account
{
    private string _acctHolderName;
    private int _acctNo;
    private double _annualIntrRate;
    private decimal _balance;

    public Account(string acctHolderName, int _acctNo)
    {
        _acctHolderName = acctHolderName;
        _annualIntrRate = annualIntrRate;
        _balance = 0m;
        _annualIntrRate = 0.0d;
    }

    public virtual decimal Deposit(decimal amount)
    {
        return 0m;
    }

    public virtual decimal Withdraw(decimal amount)
    {
        return 0m;
    }

    public Load(Account File)
    {
        return null;
    }

    public Save(Account File)
    {
        return null;
    }

    public string acctHolderName
    {
        get { return _acctHolderName; }
    }

    public int acctNo
    {
        get { return _acctNo; }
    }

    public double AnnualInterestRate
    {
        get { return _annualInterestRate; }
        set { _annualInterestRate = value; }
    }
}