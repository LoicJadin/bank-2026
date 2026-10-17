
namespace Bank2026
{
    public class SavingsAccount
    {
        public string Number { get; set; } = string.Empty;

        public double Balance { get; private set; }

        public DateTime DateLastWithdraw { get; private set; }

        public Person Owner { get; set; }

        public SavingsAccount(string number, Person owner)
        {
            Number = number;
            Owner = owner;
            Balance = 0;
            DateLastWithdraw = DateTime.MinValue;
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

            if (amount > Balance)
            {
                Console.WriteLine("Solde insuffisant.");
                return;
            }

            Balance -= amount;
            DateLastWithdraw = DateTime.Now;
        }
    }
}
