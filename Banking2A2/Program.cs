using Banking2A2.Models.Domain;
using System;

namespace Banking2A2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myBA = new BankAccount("123-12312312-99");
            Console.WriteLine($"Account {myBA.AccountNumber} created...");
            Console.WriteLine($"Balance is currently {myBA.Balance} Euro");
 
            BankAccount myOtherBA = new BankAccount("123-12312312-99", 50);
            Console.WriteLine($"Other account {myOtherBA.AccountNumber} created...");
            Console.WriteLine($"Balance is currently {myOtherBA.Balance} Euro");

            myBA.Deposit(1000);
            Console.WriteLine($"Balance is currently {myBA.Balance} Euro");
            myBA.Deposit(200);
            Console.WriteLine($"Balance is currently {myBA.Balance} Euro");
            myBA.Withdraw(100);
            Console.WriteLine($"Balance is currently {myBA.Balance} Euro");
            Console.ReadKey();
        }
    }
}
