using example.Bank;
using System;

namespace example
{
    class Program
    {
        
        static void Main(string[] args)
        {

            //Console.WriteLine("Please Enter Name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("My name is " + name);
            //Myfunction(8, "AARTI");
            //Class1.Myprogram();
            //GuessingGame g = new GuessingGame();
            //g.Play();
            //BankAccount b = new BankAccount();
            /*#############################################*/
            //BankAccount b1 = new BankAccount(100);
            //BankAccount b2 = new BankAccount(1000);
            //b1.Deposit(100);
            //b2.Withdrawl(500);

            //b1.MoneyTransfer(50, b2,out decimal sb, out decimal db);
            //(decimal sourceBalance, decimal destinationBalance) = b1.MoneyTransfer(50, b2);
            //Console.WriteLine(sourceBalance);
            //Console.WriteLine(b1.GetBalance());
            //b1.SetBalance(100000);
            //b1.Balance = 10;
            //b1.Id = 1;
            //Console.WriteLine(b1.Id);
            //Console.WriteLine(b1.Balance);
            //CaimanBankAccount caimanusecase = new CaimanBankAccount(101,"ThisCodeIsSecret");
            //caimanusecase.Deposit(100);
            //Pillar of Obj Oriented => Polimorphism
            //BankAccount ba = new CaimanBankAccount(101,"example");
            //HandleBankAccount(caimanusecase);
            //BankAccount ba2 = new BankAccount(101);
            //HandleBankAccount(ba2);


            //ClassTemplate ct1 = new ClassTemplate(123);
            //ClassTemplate ct2 = new ClassTemplate(123,"Ciao");
            //ct1.increasevalfunc(5);
            //ct2.PrintToCento(60);

            //Polimophism => Runtime case
            //It's usefull to call with a class with different constructor to access to Overrided functions
            BankAccount b;
            Random r = new Random();
            if ((r.Next() % 2) == 0)
            {
                b = new BankAccount(100);
            }
            else
            {
                b = new CaimanBankAccount(100, "cIAO");

            }
            b.Deposit(100);
            //AbstractBank.BankAccount x = new AbstractBank.BankAccount(100);
            AbstractBank.BankAccount x = new AbstractBank.ItalianBankAccount(100, "Margherita");
            try
            {
            b.Withdrawl(1000);

            }
            catch(InsufficientFoundException bex)
            {
                Console.WriteLine(bex.Message);
                Console.WriteLine(bex.StackTrace);
            }
            finally
            {
                Console.WriteLine("Close Action(ex. Db Connection) despite everything!");           
            }

          
        }
        static void Myfunction(int x, string name)
        {
        }
        static void HandleBankAccount(BankAccount a)
        {
            if (a.Balance > 100) 
            {

                //CaimanBankAccount c = (CaimanBankAccount)a; 
                //c.Deposit(10);
                a.Deposit(10);

            }
        }

    }

}
