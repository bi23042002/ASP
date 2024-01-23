using Demo_Session3_MVC.Models;

namespace Demo_Session3_MVC.Services
{
    public interface AccountService
    {
        public Account Login(string username, string password);
    }
}
