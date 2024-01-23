using DemoSession4_ASPNET_CORE_MVC.Models;

namespace DemoSession4_ASPNET_CORE_MVC.Services
{
    public class AccountServiceImpl : AccountService
    {
        private DatabaseContext db;
        public AccountServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }
        public bool Create(Account account)
        {
            try
            {
                db.Accounts.Add(account);
                return db.SaveChanges() > 0;
            } 
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var account = db.Accounts.Find(id);
                account.Roles.Clear();
                db.Accounts.Remove(account);
                return db.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }

        public Account FindById(int id)
        {
            return db.Accounts.SingleOrDefault(a => a.Id == id);
        }

		public bool Login(string username, string password)
		{
            var account = db.Accounts.SingleOrDefault(a => a.Username == username);
            if (account != null)
			{
                return BCrypt.Net.BCrypt.Verify(password,account.Password) && account.Status;
			}
            return false;
		}

		public bool Update(Account account)
        {
            try
            {
                db.Entry(account).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return db.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
