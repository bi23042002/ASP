using Demo_Session3_MVC.Models;

namespace Demo_Session3_MVC.Services
{
    public class AccountServiceImpl : AccountService
    {
        private List<Account> accounts;

        public AccountServiceImpl()
        {
            accounts = new List<Account>()
            {
                new Account() { Username = "acc1", Password = "$2b$10$QerNb3HGQ6TIw2yJJuvB3eTPEK6ZuzjV3rxstw9sIWPFXwJecVzmy", FullName = "Name 1" },
                new Account() { Username = "acc2", Password = "$2b$10$rYrecbkfVM6ZqrUQdC6DEuEPj4hu.Xfg79WUf1j4aWsC3IMqzUTPC", FullName = "Name 2" },
                new Account() { Username = "acc3", Password = "$2b$10$F.30bMiPYXKkm66VDqpg0uCX69xEBSk.iKjJdgbRz2./ol2nAi2uq", FullName = "Name 3" }
            };
        }

        public Account Login(string username, string password)
        {
            var account = accounts.SingleOrDefault(a => a.Username == username);
            if (account != null)
            {
                if (BCrypt.Net.BCrypt.Verify(password, account.Password))
                {
                    return account;
                }
            }
            return null;
        }
    }
}
