using System;
using System.Collections.Generic;
using System.Text;

namespace example.AbstractBank
{
    public abstract class BankAccount : Object //Object is the mother class for the orphan class
    {
        //encapsulation
        protected decimal balance;
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
        //Contructors
        //public BankAccount()
        //{
        //    balance = 100;
        //    Console.WriteLine("Default Constructor");
        //}

        public BankAccount(decimal d)
        {
            balance = d;
            Console.WriteLine("BankAccount Constructor taking initial Balance");
        }
        public BankAccount(decimal d,string s)
        {
            balance = d;
            Console.WriteLine("BankAccount Constructor taking initial Balance");
        }
        //Abstract Method
        public abstract decimal Deposit(decimal amount);
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
