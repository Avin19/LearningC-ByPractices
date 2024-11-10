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

public class ATM
{
    private string _accountNumber;
    private int _pin;
    private List<UserAccount> users = new List<UserAccount>();
    public ATM()
    {
        Console.WriteLine(" Welcome to ATM System ");
        ShowMenu();

    }
    public void ShowMenu()
    {
        bool isExit = false;
        Console.WriteLine(" Show Menu \n 1.Register User \n 2.Login \n 3.ShowMenu \n 4.Exit ");
        int i = Convert.ToInt32(Console.ReadLine());
        switch (i)
        {
            case 1:
                RegisterUser();
                break;
            case 2:
                Login();
                break;
            case 3:
                ShowMenu();
                break;
            case 4:
                isExit = true;
                break;
            case 5:
                foreach (UserAccount user in users)
                {
                    Console.WriteLine($"{user.AccountNumber} ,  {user.GetPin()} , {user.Balance}");
                }
                break;
        }
        while (!isExit)
        {
            ShowMenu();
        }

    }

    private void Login()
    {
        string uAN = GetUserAccountNumber();
        int uPin = GetPin();
        foreach (UserAccount user in users)
        {
            if (user.AccountNumber.Equals(uAN))
            {
                if (user.Pin == uPin)
                {
                    Console.WriteLine($" Welcome User! {user.AccountNumber}: Amount Avaiable in Your Account {user.Balance} ");
                    UserData(user);
                }
                else
                {
                    Console.WriteLine(" Incorrect User information");
                }
            }
            else
            {
                Console.WriteLine(" Incorrect User information");
            }
        }


    }
    public string GetUserAccountNumber()
    {
        Console.WriteLine(" Enter of your Account Number");
        string _userAccount = Console.ReadLine();
        return _userAccount;
    }
    public int GetPin()
    {
        Console.WriteLine(" Enter pin of account :" + _accountNumber);
        int _pin = Convert.ToInt32(Console.ReadLine());
        return _pin;

    }
    public void RegisterUser()
    {
        string userAccount = GetUserAccountNumber();
        int pin = GetPin();

        UserAccount user = new UserAccount(userAccount, pin);
        users.Add(user);
        UserData(user);

    }

    public void UserData(UserAccount user)
    {
        Console.WriteLine(" \n 1. Desposite \n 2.Withdraw \n 3. CheckBalance ");
        int i = Convert.ToInt32(Console.ReadLine());
        switch (i)
        {
            case 1:
                int amount = Convert.ToInt32(Console.ReadLine());
                user.Deposite(amount);
                break;
            case 2:
                int amount1 = Convert.ToInt32(Console.ReadLine());
                user.Withdraw(amount1);
                break;
            case 3:
                user.CheckBalance();
                break;
        }

    }
}

