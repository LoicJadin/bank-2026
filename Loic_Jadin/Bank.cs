
namespace Bank2026
{
    public class Bank
    {
        public Dictionary<string, CurrentAccount> Accounts { get; private set; }
        public string Name { get; set; }

        public Bank(string name)
        {
            Name = name;
            Accounts = new Dictionary<string, CurrentAccount>();
        }

        public void AddAccount(CurrentAccount account)
        {
            Accounts.Add(account.Number, account);
        }

        public void DeleteAccount(string number)
        {
            Accounts.Remove(number);
        }
    }
}
