using System;

namespace SavingAccount
{
    class SavingsAccount
    {
        private double _annualInterest;
        private double _balance;
        private double _totalDeposit;
        private double _totalWithdrawn;
        private double _interestEarned;
        private double _interestRate;

        public SavingsAccount(double balance)
        {
            _balance = balance;
        }

        public void Withdrawn(double i)
        {
            _balance -= i;
            _totalWithdrawn += i;
        }

        public void Deposit(double i)
        {
            _balance += i;
            _totalDeposit += i;
        }

        public void MonthlyInterestRate(double i)
        {
            _interestRate =  i / 12;
        }

        public void MonthlyInteresetEarned()
        {
            _interestEarned += _balance * _interestRate;
            _balance += _balance * _interestRate;
        }

        public double Interest()
        {
            return _interestEarned;
        }

        public double TotalWithdrawn()
        {
            return _totalWithdrawn;
        }

        public double TotalDeposit()
        {
            return _totalDeposit;
        }

        public double Balance()
        {
            return _balance;
        }

    }
}
