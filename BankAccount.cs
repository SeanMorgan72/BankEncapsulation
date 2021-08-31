using System;
namespace BankEncapsulationProject
{
    public class BankAccount
    {
        public BankAccount()
        {
        }

        private decimal balance = 0;

        public void Deposit(decimal deposit)
        {
            balance += deposit;
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }
}
