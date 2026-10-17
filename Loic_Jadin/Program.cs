


namespace Bank2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                FirstName = "Loïc",
                LastName = "Jadin",
                BirthDate = new DateTime(2002, 11, 13)
            };

            Bank bank = new Bank("Bank 2026");

            CurrentAccount current =
                new CurrentAccount("BE1", person, 200);

            SavingsAccount savings =
                new SavingsAccount("BE2", person);

            current.Deposit(500);
            savings.Deposit(1000);

            bank.AddAccount(current);
            bank.AddAccount(savings);

            Console.WriteLine($"Banque : {bank.Name}");
            Console.WriteLine($"Client : {person.FirstName} {person.LastName}");
            Console.WriteLine($"Solde courant : {bank.GetBalance("BE1")} €");
            Console.WriteLine($"Solde épargne : {bank.GetBalance("BE2")} €");

            Console.WriteLine($"Total des comptes : {bank.GetTotalBalance(person)}€");

            current.Withdraw(600);
            Console.WriteLine($"Solde du courant après le retrait : {bank.GetBalance("BE1")}€");

            bank.DeleteAccount("BE2");
            Console.WriteLine($"Nombre de compte restant : {bank.Accounts.Count}");


        }
    }
}
