using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace S10257116_MyBankApp
{
    internal class BankAccount
    {   
       
        private string accNo;
        public string AccNo
        { 
            get { return accNo; } 
            set {  accNo = value; } 
        }

        private string accName;
        public string AccName
        {
            get { return accName; }
            set { accName = value; }
        }
        private double balance;
        public double Balance
        { get { return balance; } 
          set {  balance = value; } 
        }

        public BankAccount (string accNo, string accName, double balance)
        {
            AccNo = accNo;
            AccName = accName;
            Balance = balance;
        }

        public void deposit(double balance)
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
}
