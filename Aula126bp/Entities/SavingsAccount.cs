namespace Aula126bp.Entities
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

        public void UpdateBalence( )
        {
            Balance += Balance * InterestRate;
        }
    }


}
