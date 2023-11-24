using CustomExceptionAccount.Entties.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionAccount.Entties
{
    internal class Account
    {
        public int NumberAccount { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int numberAccount, string holder, double balance, double withdrawLimit)
        {

            
            NumberAccount = numberAccount;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amouth)
        {
            Balance += amouth;
        }

        public void Withdraw(double amouth)
        {
            if (amouth > WithdrawLimit)
            {
                throw new DomainException("The amouth excess the withdraw limit");
            }

            if (amouth > Balance) 
            {
                throw new DomainException("Not enough balance");
            }


            Balance -= amouth;
        }

    }
}
