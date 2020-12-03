using System;
using System.Collections.Generic;
using System.Text;

namespace example.Interfaces
{
    class IndianBankAccount : BankAccount
    {
        public decimal Balance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Deposit(decimal amount)
        {
            throw new NotImplementedException();
        }

        public void WithDraw(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
