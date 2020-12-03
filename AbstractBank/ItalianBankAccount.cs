using System;
using System.Collections.Generic;
using System.Text;

namespace example.AbstractBank
{
    class ItalianBankAccount : BankAccount
    {
        public string FavouritePizza { get; set; }
        public ItalianBankAccount(decimal initialBalance,string favouritePizza) : base(initialBalance) 
        {
            FavouritePizza = favouritePizza;

        }
        public override decimal Deposit(decimal amount)
        {
            //85         // decimal //
            //0213       // octal //
            //0x4b       // hexadecimal //
            //30         // int //
            //30u        // unsigned int //
            //30l        // long //
            //30ul       // unsigned long //

            if (amount > 1000) 
            { 
                this.balance += amount * 1.1m;
            }
            else 
            {
                this.balance += amount;
            }
            Console.WriteLine("executing deposit of child");
            return this.balance;

        }

    }
}
