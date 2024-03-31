using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Account
{
    // Properties
    public int AccountNumber { get; private set; }
    public double Balance { get; private set; }
    public string Type { get; private set; }

    // Constructors
    public Account(int accountNumber, double initialBalance, string type = "Checking")
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
        Type = type;
    }

    // Methods
    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"{amount} deposited into account {AccountNumber}. New balance: {Balance}");
    }

    public void Withdraw(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"{amount} withdrawn from account {AccountNumber}. New balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }

    // Overloaded methods
    public void Deposit(double amount, string description)
    {
        Deposit(amount);
        Console.WriteLine($"Description: {description}");
    }

    public void Withdraw(double amount, string description)
    {
        Withdraw(amount);
        Console.WriteLine($"Description: {description}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating a checking account
        Account checkingAccount = new Account(123456, 1000);
        checkingAccount.Deposit(500);
        checkingAccount.Withdraw(200);

        // Creating a savings account
        Account savingsAccount = new Account(654321, 5000, "Savings");
        savingsAccount.Deposit(1000, "Monthly savings");
        savingsAccount.Withdraw(200, "Emergency expense");
    }
}

