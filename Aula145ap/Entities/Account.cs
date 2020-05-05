using System;
using System.Collections.Generic;
using System.Text;
using Aula145ap.Entities.Exceptions;
using System.Globalization;

namespace Aula145ap.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }

        public double WithDrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        } 
        
        public void withDraw(double amount)
        {
            if (amount > WithDrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit: ");
            }
            
            if (amount > Balance)
            {
                throw new DomainException("Not enough balance: ");
            }
            
            Balance -= amount;

        }

        public override string ToString()
        {
            return "New Balance of Account: "
                +Number
                +", Holder: "
                +Holder
                +", Balance: "
                +Balance.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
