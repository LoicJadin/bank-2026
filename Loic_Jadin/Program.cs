
using System;

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

            CurrentAccount account =
                new CurrentAccount("BE001", person, 200);

            Bank bank = new Bank("Bank 2026");

            bank.AddAccount(account);

            Console.WriteLine(bank.Name);
            Console.WriteLine(bank.Accounts.Count);

            bank.DeleteAccount("BE001");

            Console.WriteLine(bank.Accounts.Count);
        }
    }
}
