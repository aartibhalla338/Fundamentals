using System;
using System.Collections.Generic;
using System.Text;

namespace example.Interfaces
{
    interface BankAccount
    {
        void Deposit(decimal amount);
        void WithDraw(decimal amount);
        public decimal Balance { get; set; }
    }
}
