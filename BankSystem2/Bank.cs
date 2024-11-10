
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
public enum BankAccountType
{
    SavingAccount,
    CurrentAccount,
    FixedDepositAccount
}
public class Bank
{
    private BankAccount bankAccount;
    public BankAccountType bankAccountType;

    public List<BankAccount> bankAccountList = new List<BankAccount>();

    public Bank(BankAccount _bankAccount, BankAccountType _bankAccountType)
    {
        this.bankAccount = _bankAccount;
        bankAccountList.Add(bankAccount);
        bankAccountType = _bankAccountType;
    }

    public void CheckUser(string _username ,int pin)
    {
        if( bankAccountList.Contains(bankAccount) )
        {
            if(bankAccount.AccountNumber == _username)
            {
                
            }
        }
    }


}
