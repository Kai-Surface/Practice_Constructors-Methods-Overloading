using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Constructors_Methods_Overloading
{
    internal class BankAccount
    {
        string _accountNumber;
        string _customerName;
        double _balance;

        public BankAccount(string accountNumber, string customerName, double balance)
        {
            AccountNumber = accountNumber;
            CustomerName = customerName;
            Balance = balance;
        }

        public string AccountNumber { get => _accountNumber; set => _accountNumber = value; }
        public string CustomerName { get => _customerName; set => _customerName = value; }
        public double Balance { get => _balance; set => _balance = value; }

        public void Deposit(double amount)
        {
            if(amount >= 0)
            {
                _balance += amount;
            }
        }

        public void Withdraw(double amount)
        {
            if (amount >= 0 && amount <= _balance)
            {
                _balance -= amount;
            }
        }

        public override string ToString()
        {
            return $"{_accountNumber} - {_customerName} - Current Balance: {_balance.ToString("c")}";
        }
    }
}
