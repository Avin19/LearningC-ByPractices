
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

public class SavingsAccount : BankAccount
{
    public SavingsAccount(string name,string accountNumber , int pin , BankAccountType bankAccountType )
    {
        
    }
}
