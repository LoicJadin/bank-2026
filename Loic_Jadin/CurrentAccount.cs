
namespace Bank2026
{
    public class CurrentAccount
    {
        public string Number { get; set; }

        public double Balance { get; private set; }

        public double CreditLine { get; set; }

        public Person Owner { get; set; }

        public CurrentAccount(string number, Person owner, double creditLine)
        {
            Number = number;
            Owner = owner;
            CreditLine = creditLine;
            Balance = 0;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Le montant doit être positif.");
                return;
            }

            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Le montant doit être positif.");
                return;
            }

            if (Balance - amount < -CreditLine)
            {
                Console.WriteLine("Solde insuffisant.");
                return;
            }

            Balance -= amount;
        }
    }
}
