using System;
using aula128ap.Entities;

namespace aula128ap.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }



        public BusinessAccount()

        {

        }



        public BusinessAccount(int number, string holder, double balance, double loanLimit)

            : base(number, holder, balance)

        {

            LoanLimit = loanLimit;

        }



        public void Loan(double amount)

        {

        }

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
