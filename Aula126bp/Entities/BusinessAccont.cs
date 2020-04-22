using Aula126bp.Entities;
namespace Aula126bp.Entities
{
    class BusinessAccont : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccont()
        {

        }

        public BusinessAccont(int number, string holder, double balance, double loanLimit)
          : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
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
