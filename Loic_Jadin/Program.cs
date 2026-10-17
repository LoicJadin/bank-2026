

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

            SavingsAccount savings =
                new SavingsAccount("SAV001", person);

            savings.Deposit(500);
            savings.Withdraw(100);

            Console.WriteLine(savings.Balance);
        }
    }
}