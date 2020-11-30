using System;
using System.Collections.Generic;
using System.Text;

namespace example.Bank
{
    class CaimanBankAccount : BankAccount
    {

        public string SecretCode { get; set;} 
        //Classes + Name function_Pascal Case each lfirst letter that compose a variable is up case
        //Anything else Camel cases
        public CaimanBankAccount(decimal initialBalance, string secretCode) : base(initialBalance,"Ciao")
        {
            SecretCode = secretCode;
            //Balance = initialBalance; Orrible Idea! The variables shall be initialized from Mother consructors
            Console.WriteLine("CaimanBankAccount Constructor taking initial Balance");
        }
        public void AvoidTaxes() { }
        public override decimal Deposit(decimal amount)
        {
            /*85         /* decimal */
            /*0213       /* octal */
            /*0x4b       /* hexadecimal */
            /*30         /* int */
            /*30u        /* unsigned int */
            /*30l        /* long */
            /*30ul       /* unsigned long */

            this.balance += amount * 1.1m;
            Console.WriteLine("executing deposit of child");
            return this.balance;
           
        }

    }
}
