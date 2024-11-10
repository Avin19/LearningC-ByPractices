/*
Task: Create an ATM system where users can deposit, withdraw, and check their balance. 
Implement user authentication and transaction history.
Requirements:
Create a UserAccount class with properties like AccountNumber, Pin, Balance, and TransactionHistory.
Create methods for Deposit(decimal amount), Withdraw(decimal amount), and CheckBalance().
Implement user authentication using AccountNumber and Pin.
Maintain a transaction history for each user.
Write a ATM class that handles user interaction.
csharp
*/

public class UserAccount
{
    private int pin;
    public int Pin
    {
        get
        {
            return pin;
        }
        private set
        {

        }
    }
    public string AccountNumber { get; set; }
    public float Balance { get; set; }
    public UserAccount(string _accountNumber, int pin)
    {
        this.AccountNumber = _accountNumber;
        this.pin = pin;
    }
    private List<string> transactionHistory = new List<string>();

    public void Deposite(float amount)
    {
        Balance += amount;
        Console.WriteLine("Your new Balance is :" + Balance);
    }
    public void Withdraw(float amount)
    {
        if (Balance - amount > 0)
        {
            Balance -= amount;
        }
        Console.WriteLine("Your new Balance is " + Balance);
    }

    public float CheckBalance()
    {
        return Balance;
    }
    public int GetPin()
    {
        return Pin;
    }

}

