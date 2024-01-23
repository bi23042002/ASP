using DemoSession4_ASPNET_CORE_MVC.Models;

namespace DemoSession4_ASPNET_CORE_MVC.Services
{
    public interface AccountService
    {

        public Account FindById(int id);
        public bool Create(Account account);
        public bool Delete(int id);
        public bool Update(Account account);
        public bool Login(string username, string password); 

    }
}
