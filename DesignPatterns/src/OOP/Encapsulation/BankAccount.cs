using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.src.OOP.Encapsulation
{
    public class BankAccount
    {
        private decimal _balance;

        public BankAccount(decimal amount)
        {
            Deposit(amount);
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public void Deposit(decimal amount)
        {
            if(amount < 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            _balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            if (_balance < amount )
            {
                throw new ArgumentException("Insufficient funds.");
            }

            _balance -= amount;
        }
    }
}
