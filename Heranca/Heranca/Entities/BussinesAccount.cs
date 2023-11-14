using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
    internal class BussinesAccount : Account
    {
        public double LoanLimit { get; set; }

        public BussinesAccount()
        {
        }

        public BussinesAccount(int number, string holder, double balance, double loanLimite) : base(number,holder,balance)
        {
            LoanLimit = loanLimite;
        }

        public void Loan(double amount) 
        {
            if (amount <= LoanLimit) 
            { 
                Balance += amount;
            }
        }
    }
}
