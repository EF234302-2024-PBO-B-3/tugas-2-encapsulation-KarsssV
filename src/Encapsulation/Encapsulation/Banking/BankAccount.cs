using System;

namespace Encapsulation.Banking
{
    public class BankAccount
    {
        private string _accountNumber;
        private string _accountHolder;
        private double _balance;

        public string AccountNumber
        {
            get { return _accountNumber; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _accountNumber = "Unknown";
                }
                else
                {
                    _accountNumber = value;
                }
            }
        }

        public string AccountHolder
        {
            get { return _accountHolder; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _accountHolder = "Unknown";
                }
                else
                {
                    _accountHolder = value;
                }
            }
        }

        public double Balance
        {
            get { return _balance; }
            private set
            {
                if (value < 0)
                {
                    _balance = 0.0;
                }
                else
                {
                    _balance = value;
                }
            }
        }

        // Konstruktor untuk menginisialisasi akun bank
        public BankAccount(string accountNumber, string accountHolder, double balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;

            if (balance < 0)
            {
                Balance = 0.0;
            }
            else
            {
                Balance = balance;
            }
        }

        // Metode untuk menambahkan saldo ke akun
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance = _balance + amount;
            }
        }

        // Metode untuk menarik saldo dari akun
        public void Withdraw(double amount)
        {
            if (amount > 0 && _balance >= amount)
            {
                _balance = _balance - amount;
            }
        }

        // Metode untuk mendapatkan saldo saat ini
        public double GetBalance()
        {
            return _balance;
        }
    }
}
