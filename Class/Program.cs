using System;


BankAccount account = new BankAccount("Nilesh", 10000m);

account.DisplayBalance();

account.Deposit(5000m);

account.DisplayBalance();



public class BankAccount
{
    public string AccountHolder {  get; }

    public decimal Balance {  get; private set; }

    public BankAccount(string accountHolder, decimal initialBalance)
    {
        if(string.IsNullOrWhiteSpace(accountHolder))
        {
            throw new ArgumentNullException("Account holder is required");
        }

        if(initialBalance < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(initialBalance));
        }

        AccountHolder = accountHolder;
        Balance = initialBalance;
    }


    public void DisplayBalance()
    {
        Console.WriteLine($"{AccountHolder}'s Balance : {Balance}");
    }

    public void Deposit(decimal amount)
    {
        if(amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount));
        }

        Balance += amount;
    }
}


