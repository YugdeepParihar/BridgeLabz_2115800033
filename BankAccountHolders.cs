using System;
using System.Collections.Generic;

class Bank
{
    public string BankName { get; set; }
    public List<Customer> Customers { get; private set; } 

    public Bank(string bankName)
    {
        BankName = bankName;
        Customers = new List<Customer>(); 
    }

    public void OpenAccount(Customer customer, double initialDeposit)
    {
        if (initialDeposit < 2000)
        {
            Console.WriteLine("Minimum deposit to open an account is 2000.");
            return;
        }

        customer.Accounts.Add(new BankAccount(this, initialDeposit)); 
        if (!Customers.Contains(customer))
        {
            Customers.Add(customer); 
        }

        Console.WriteLine("Account opened for " + customer.Name + " in " + BankName + " with balance " + initialDeposit + ".");
    }

    public void DisplayCustomers()
    {
        Console.WriteLine("\nList of Customers in " + BankName + ":");
        if (Customers.Count == 0)
        {
            Console.WriteLine("No customers yet.");
        }
        else
        {
            foreach (Customer customer in Customers)
            {
                Console.WriteLine(customer.Name + " has " + customer.Accounts.Count + " account(s).");
            }
        }
    }
}

class Customer
{
    public string Name { get; set; }
    public List<BankAccount> Accounts { get; private set; } 

    public Customer(string name)
    {
        Name = name;
        Accounts = new List<BankAccount>(); 
    }

    public void ViewBalance()
    {
        Console.WriteLine("\nAccount details for " + Name + ":");
        if (Accounts.Count == 0)
        {
            Console.WriteLine("No bank accounts found.");
        }
        else
        {
            foreach (BankAccount account in Accounts)
            {
                Console.WriteLine("Bank: " + account.Bank.BankName + " - Balance: " + account.Balance);
            }
        }
    }
}

class BankAccount
{
    public Bank Bank { get; set; } 
    public double Balance { get; private set; }

    public BankAccount(Bank bank, double initialBalance)
    {
        Bank = bank;
        Balance = initialBalance;
    }
}

class Program
{
    static void Main()
    {
        Bank sbiBank = new Bank("State Bank of India");

        Customer customer1 = new Customer("Rohan");
        Customer customer2 = new Customer("Shyam");

        sbiBank.OpenAccount(customer1, 5000);
        sbiBank.OpenAccount(customer2, 3000);
        sbiBank.OpenAccount(customer2, 2500);

        customer1.ViewBalance();
        customer2.ViewBalance();

        sbiBank.DisplayCustomers();
    }
}