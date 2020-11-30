using System;
using System.Collections.Generic;
using System.Text;

namespace example.Bank
{
    public class BankAccount
    {
        //encapsulation
        private decimal balance;
        //private int id;
        private string id;
        private string name;
        //Property
        public  string Name 
        { 
          get { return name;}

          set
            {name=value;} 
        }
        //Automatic property
        public string CustomerName { get; set; }
        public int Id { get {
                int result = Int32.Parse(id);
                
                return result; } 
            set 
            {
            if (value > 1000)
                {
                    id = value.ToString();
                }
            } 
        }
        public decimal Balance
        {
            get { return balance; }
            set
            {
                if (value > 0)
                {
                    balance = value;
                }
            }
        }
        //public BankAccount()
        //{
        //    Console.WriteLine("Default Constructor");
       // }
        public BankAccount(decimal d)
        {
            balance = d;
            Console.WriteLine("Constructor taking initial Balance");
        }
        public BankAccount(int d)
        {
            balance = d;
            Console.WriteLine("Constructor taking initial Balance");
        }
        public decimal Deposit(decimal amount)
        {
            this.balance += amount;
            return this.balance;
        }
        public decimal Withdrawl(decimal amount)
        {
            if (amount < this.balance)
            {
                this.balance -= amount;
                
            }            
            return this.balance;
        }
        public void MoneyTransfer(decimal amount,BankAccount destination,out decimal sourceBalance, out decimal destinationBalance)
        {
            this.Withdrawl(50);
            destination.Deposit(50);
            sourceBalance = this.balance;
            destinationBalance = destination.balance;
        }
        public (decimal sb,decimal db) MoneyTransfer(decimal amount, BankAccount destination)
        {
            this.Withdrawl(50);
            destination.Deposit(50);
            return (this.balance, destination.balance);
        }
        public decimal GetBalance()
        {
            return balance;
        }
        public void SetBalance(decimal newBalance)
        {
            if (newBalance >= 0)
            {
                balance = newBalance;
            }

        }
    }
}
