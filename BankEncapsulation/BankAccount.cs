using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    internal class BankAccount
    {
        private double balance = 0;

        public void Deposit(double val)
        {
            balance += val;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
