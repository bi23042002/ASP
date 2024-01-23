using DemoSession4_ASPNET_CORE_MVC.Models;
using DemoSession4_ASPNET_CORE_MVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoSession4_ASPNET_CORE_MVC.Controllers
{
    [Route("account")]
    public class AccountController : Controller
    {
        private AccountService accountService;
        private RoleService roleService;
        public AccountController(AccountService _accountService, RoleService _roleService)
        {
            accountService = _accountService;
            roleService = _roleService;
        }
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("index2")]
        public IActionResult Index2()
        {
            var account = new Account
            {
                Username = "acc4",
                Password = BCrypt.Net.BCrypt.HashPassword("123"),
                Fullname = "name 4",
                Email = "e.gmail",
                Status = true,
                Roles = new List<Role>
                {
                    roleService.findById(1),
                    roleService.findById(3),
                    roleService.findById(4),
                }
            };
            Debug.WriteLine(accountService.Create(account));    
            return RedirectToAction("Index");
        }
        [Route("index3")]
        public IActionResult Index3()
        {
            Debug.WriteLine(accountService.Delete(1));
            return RedirectToAction("Index");
        }
        [Route("index4")]
        public IActionResult Index4()
        {
            var account = accountService.FindById(8);
            account.Fullname = "ACV";
            account.Status = false;
            account.Password = BCrypt.Net.BCrypt.HashPassword("456");
            account.Roles.Clear();
            account.Roles.Add(roleService.findById(2));
            account.Roles.Add(roleService.findById(3));
            account.Roles.Add(roleService.findById(4));
            Debug.WriteLine(accountService.Create(account));

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Login()
		{
            return View("Login");
		}
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (accountService.Login(username, password))
			{
                ViewBag.msg = "Valid";
			}
			else
			{
                ViewBag.msg = "Invalid";
			}
            return View("Login");
        }
    }
}
