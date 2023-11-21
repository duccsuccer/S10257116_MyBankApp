using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class BankAccount
    {

        private string accNo;
        public string AccNo
        {
            get { return accNo; }
            set { accNo = value; }
        }

        private string accName;
        public string AccName
        {
            get { return accName; }
            set { accName = value; }
        }
        private double balance;
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public BankAccount(string accNo, string accName, double balance)
        {
            AccNo = accNo;
            AccName = accName;
            Balance = balance;
        }

        public void Deposit(double balance)
        {
            Balance += balance;
        }
        public bool Withdraw(double balance)
        {
            if (Balance <= balance)
            {
                return false;
            }
            else
            {
                Balance -= balance;
                return true;
            }
        }
        public override string ToString()
        {
            return $"Account Number: {AccNo}, Account Name: {AccName}, Balance: ${Balance}";
        }
    }

    class SavingsAccount : BankAccount
    {
        private double rate;
        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }
        public SavingsAccount(string accNo, string accName, double balance, double rate)
            : base(accNo, accName, balance)
        {
            Rate = rate;
        }

        public double CalculateInterest()
        {
            double interest = Balance * (Rate / 100);
            return interest;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Interest Rate: {Rate}%";
        }

    }
}
