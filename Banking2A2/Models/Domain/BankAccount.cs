using System;

namespace Banking2A2.Models.Domain
{
    public class BankAccount
    {
        // private string _accountNumber;
        // public const decimal WithdrawCost = 0.10M; 
        // public static readonly decimal _withdrawCost = 0.10M;

        #region Fields
        private decimal _balance;

        #endregion

        #region Properties
        public string AccountNumber { get; private set; }
        public decimal Balance {
            get {
                return _balance;
            }
            private set {
                if (value < 0)
                    throw new ArgumentException("Balance cannot be negative");
                _balance = value;
            }
        } 
        #endregion

        #region Constructors
        public BankAccount(string accountNumber) : this(accountNumber, 0)
        {
        }

        public BankAccount(string accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        #endregion

        #region Methods
        public void Deposit(decimal amount/*, int nrOfTimes = 1*/)
        {
            if (amount < 0)
                throw new ArgumentException("Amount cannot be negative");
            Balance += amount/* * nrOfTimes*/;
        }

        public void Withdraw(decimal amount)
        {
            if (amount < 0)
                throw new ArgumentException("Amount cannot be negative");
            Balance -= amount;
        } 
        #endregion
    }
}
