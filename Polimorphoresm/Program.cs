namespace Polimorphoresm
{
    internal class Program
    {

        public static bool HaveVowels(string text = "")
        {
            List<string> vowels = new List<string> { "a", "e", "i", "o", "u" };
            bool contain=false;
            for (int i = 0; i < vowels.Count; i++)
            {
                if (text.ToLower().Contains(vowels[i]))
                {
                    contain= true;
                    break;
                }
            }

            return contain;
        }


        static void Main()
        {
            // Accounts
            var accounts = new List<Account>();
            accounts.Add(new Account());
            accounts.Add(new Account("Larry"));
            accounts.Add(new Account("Moe", 2000));
            accounts.Add(new Account("Curly", 5000));

            AccountUtil<Account>.Deposit(accounts, 1000);
            AccountUtil<Account>.Withdraw(accounts, 2000);

            // Savings
            var savAccounts = new List<SavingsAccount>();
            savAccounts.Add(new SavingsAccount());
            savAccounts.Add(new SavingsAccount("Superman"));
            savAccounts.Add(new SavingsAccount("Batman", 2000));
            savAccounts.Add(new SavingsAccount("Wonderwoman", 5000, 5.0));

            AccountUtil<SavingsAccount>.Deposit(savAccounts, 1000);
            AccountUtil<SavingsAccount>.Withdraw(savAccounts, 2000);

            // Checking
            var checAccounts = new List<CheckingAccount>();
            checAccounts.Add(new CheckingAccount());
            checAccounts.Add(new CheckingAccount("Larry2"));
            checAccounts.Add(new CheckingAccount("Moe2", 2000));
            checAccounts.Add(new CheckingAccount("Curly2", 5000));

            AccountUtil<CheckingAccount>.Deposit(checAccounts, 1000);
            AccountUtil<CheckingAccount>.Withdraw(checAccounts, 2000);
            AccountUtil<CheckingAccount>.Withdraw(checAccounts, 2000);

            // Trust
            var trustAccounts = new List<TrustAccount>();
            trustAccounts.Add(new TrustAccount());
            trustAccounts.Add(new TrustAccount("Superman2"));
            trustAccounts.Add(new TrustAccount("Batman2", 2000));
            trustAccounts.Add(new TrustAccount("Wonderwoman2", 5000, 5.0));

            AccountUtil<TrustAccount>.Deposit(trustAccounts, 1000);
            AccountUtil<TrustAccount>.Deposit(trustAccounts, 6000);

            AccountUtil<TrustAccount>.Withdraw(trustAccounts, 2000);
            AccountUtil<TrustAccount>.Withdraw(trustAccounts, 3000);
            AccountUtil<TrustAccount>.Withdraw(trustAccounts, 500);


            AccountUtil<TrustAccount>.Withdraw(trustAccounts, 1);
            AccountUtil<TrustAccount>.Withdraw(trustAccounts, 1);
            AccountUtil<TrustAccount>.Withdraw(trustAccounts, 1);


            Console.WriteLine();

            bool have = HaveVowels("RSD");

            if (have)
            
               Console.WriteLine("Contain Vowels ");
            else
               Console.WriteLine("Don't Contain ");

        }
    }


}
