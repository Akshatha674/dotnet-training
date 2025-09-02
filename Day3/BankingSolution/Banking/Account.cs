namespace Banking;

public class Account
{

    public decimal Balance
    {
        get;
        set;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
        }

    }
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }

    }

}
