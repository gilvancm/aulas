namespace Aula126ap.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
          : base(number,holder,balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalence(double interestRate)
        {
            Balance += Balance * InterestRate;
        }
    }


}
