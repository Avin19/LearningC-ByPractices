/*
Design a class Account with private fields accountNumber and balance. 
Use public properties to get the accountNumber and get/set the balance.
Add methods Deposit() and Withdraw() with proper validation.
*/

public class Account
{
    private long accountNumber;
    private long balance;

    public long AccountNumber
    {
        get { return accountNumber; }
        set
        {
            accountNumber = value;
        }
    }
    public long Balance
    {
        get
        { return balance; }
        set { balance = value; }
    }
    public Account(long _accountNumber, long _balance)
    {
        this.AccountNumber = _accountNumber;
        this.Balance = _balance;

        DisplayInformation();
    }


    public void Desposit(long accountNumber, long amount)
    {
        if (accountNumber == this.AccountNumber)
        {
            balance += amount;

        }
        DisplayInformation();


    }
    public void Withdraw(long accountNumber, long amount)
    {
        if (accountNumber == this.AccountNumber)
        {
            if (balance - amount > 0)
            {
                balance -= amount;
                DisplayInformation();

            }
            else
            {
                System.Console.WriteLine(" Account Balance too low for this transactions ");
            }

        }
    }
    public void DisplayInformation()
    {
        System.Console.WriteLine($"Hello {AccountNumber} ! Your current balance {Balance} ");
    }

}