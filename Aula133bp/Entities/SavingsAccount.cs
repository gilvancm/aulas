using System;
using System.Collections.Generic;
using System.Text;
using Aula133bp.Entities;

namespace Aula133bp.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }



        public SavingsAccount()

        {

        }



        public SavingsAccount(int number, string holder, double balance, double interestRate)

            : base(number, holder, balance)

        {

            InterestRate = interestRate;

        }



        public void UpdateBalance()

        {

            Balance += Balance * InterestRate;

        }

        // exemplo 2 usando sealed  selando este metodo ninguem pode herdar
        public sealed override void Withdraw(double amount)
        {
            Balance -= amount;
        }
    }
}
