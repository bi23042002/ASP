using Demo_Session3_MVC.Models;
using Demo_Session3_MVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo_Session3_MVC.Controllers
{
    [Route("account")]
    public class AccountController : Controller
    {
        private AccountService accountService;
        private LanguageService languageService;
        private CertService certService;
        private RoleService roleService;

        public AccountController(AccountService _accountService, LanguageService _languageService, CertService _certService, RoleService _roleService)
        {
            accountService = _accountService;
            languageService = _languageService;
            certService = _certService;
            roleService = _roleService;
        }

        [HttpGet]
        [Route("login")]
        public IActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(string username, string password)
        {
            Debug.WriteLine("username: " + username);
            Debug.WriteLine("password: " + password);
            Account account = accountService.Login(username, password);
            if (account == null)
            {
                ViewBag.msg = "InValid";
                return View("Login");
            }
            else
            {
                ViewBag.msg = "Valid";
                return RedirectToAction("welcome");
            }

        }

        [Route("welcome")]
        public IActionResult Welcome()
        {
            return View("Welcome");
        }

        [Route("logout")]
        public IActionResult Logout()
        {
            return RedirectToAction("login");
        }

        [HttpGet]
        [Route("register")]
        public IActionResult Register()
        {
            var account = new Account()
            {
                Username = "acc1",
                Description = "abc",
                Status = true,
                Gender = "male",
                Cert = "c3",
                Role = "r3",
                Id = 123,
                Address = new Address
                {
                    Street = "Street 1",
                    Ward = "Ward 1",
                    District = "District 1"
                },
                Birthday = DateTime.Now
            };
            ViewBag.languages = languageService.findAll();
            ViewBag.certs = certService.findAll();
            ViewBag.roles = roleService.findAll();
            return View("Register", account);
        }

        [HttpPost]
        [Route("register")]
        public IActionResult Register(Account account, string[] languages)
        {
            Debug.WriteLine("Account Info");
            Debug.WriteLine("username: " + account.Username);
            Debug.WriteLine("password: " + account.Password);
            Debug.WriteLine("Full Name: " + account.FullName);
            Debug.WriteLine("Description: " + account.Description);
            Debug.WriteLine("Status: " + account.Status);
            account.Languages = languages;
            if (account.Languages != null && account.Languages.Length > 0)
            {
                Debug.WriteLine("Languages: " + account.Languages.Length);
                foreach (var language in account.Languages)
                {
                    Debug.WriteLine(language);
                }
            }
            Debug.WriteLine("Role: " + account.Role);
            Debug.WriteLine("Id: " + account.Id);
            Debug.WriteLine("Street: " + account.Address.Street);
            Debug.WriteLine("Ward: " + account.Address.Ward);
            Debug.WriteLine("District: " + account.Address.District);
            Debug.WriteLine("Birthday: " + account.Birthday.ToString("dd/MM/yyyy"));
            return RedirectToAction("register");
        }

    }
}
