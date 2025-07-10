public class BankAccount
{
    private string _owner;
    private decimal _balance;

    public BankAccount(string owner)
    {
        _owner = owner;
        _balance = 0;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            _balance += amount;
        }
        else
        {
            Console.WriteLine("Deposit must be positive.");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > _balance)
        {
            Console.WriteLine("Not enough funds.");
        }
        else
        {
            _balance -= amount;
        }
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Account Owner: {_owner}, Balance: ${_balance}");
    }
}