
/*
Task: Create a banking system that supports multiple types of accounts 
(Savings, Current, and Fixed Deposit). 
Implement account-specific behaviors and interest calculation.
Requirements:
Create an abstract base class BankAccount with properties
 like AccountNumber, Balance, and methods Deposit(), Withdraw(), 
 and CalculateInterest().
Create derived classes for SavingsAccount, CurrentAccount, and FixedDepositAccount,
 each with specific rules for interest calculation and withdrawal restrictions.
Implement a Bank class that manages accounts and allows users to create accounts,
 deposit, withdraw, and view balance and interest.
Implement a method to simulate monthly interest accrual across all accounts.

*/
using System.Text;
public class Program
{
    public static void Main(string[] args)
    {
        BankAccount bankAccount= new BankAccount("",)
        Bank bank = new Bank(bankAccount , BankAccountType.SavingAccount);
        int i = 0;
        i = ShowMenu("1. Create Account", "2. Login");
        switch (i)
        {
            case 1:
                CreateAccount();
                break;
            case 2:
                Login();
                break;

        }

    }

    private static void Login()
    {

        string accountNumber = GetString(" Enter the Account Number");
        int pin = Convert.ToInt32(GetString("Enter the Pin"));



    }

    private static void CreateAccount()
    {

    }

    private static string GetString(string message)
    {
        Console.WriteLine(message);
        return Console.ReadLine();

    }

    public static int ShowMenu(params string[] args)
    {
        StringBuilder message = new StringBuilder();
        foreach (string arg in args)
        {
            message.Append(arg + "\n");
        }
        Console.WriteLine(message);
        return Convert.ToInt32(Console.ReadLine());
    }
}
