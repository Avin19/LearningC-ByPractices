
/* Task: Create a class with encapsulated fields and properties,
 and demonstrate property validation.
Steps:
Create a class BankAccount with private fields _accountNumber and _balance.
Implement properties AccountNumber and Balance with appropriate validation.
Write a method that performs deposits and withdrawals, ensuring the balance
 cannot go negative.
*/

public class BankAccount
{
    private long _accountNumber;
    private long _balance;
    public BankAccount(int _accountNumber, int _balance)
    {
        AccountNumber = _accountNumber;
        Balance = _balance;
    }
    public long AccountNumber
    {
        get { return _accountNumber; }
        set { _accountNumber = value; }
    }
    public long Balance
    {
        get { return _balance; }
        set { _balance = value; }
    }

    public void Deposite(long _accountNumber, int amount)
    {
        if (_accountNumber == AccountNumber)
            Balance += amount;


        Console.WriteLine($" New Balance {Balance}");
    }
    public void Withdrawals(long _accountNumber, int amount)
    {
        if (_accountNumber == AccountNumber)
        {
            if (amount > 0 || Balance - amount > 0)
            {
                Balance -= amount;

            }
        }
        Console.WriteLine($" New Balance {Balance}");
    }
}

public class Program
{
    static void Main()
    {
        BankAccount myAccount = new BankAccount(123435454, 3232);

        myAccount.Deposite(myAccount.AccountNumber, 5000);
        myAccount.Withdrawals(myAccount.AccountNumber, 200);
    }
}