using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo_Session3_MVC.Controllers
{
    [Route("demo2")]
    public class Demo2Controller : Controller
    {
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("search1")]
        public IActionResult Search1(string keyword)
        {
            Debug.WriteLine(keyword);
            return RedirectToAction("index");
        }

        [HttpGet]
        [Route("search2")]
        public IActionResult Search2(double min, double max)
        {
            Debug.WriteLine("min: " + min);
            Debug.WriteLine("max: " + max);
            return RedirectToAction("index");
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(string username, string password)
        {
            Debug.WriteLine("username: " + username);
            Debug.WriteLine("password: " + password);
            var hash = BCrypt.Net.BCrypt.HashPassword(password);
            Debug.WriteLine("hash: " + hash);

            var passwordDB = "$2b$10$y0BNaA5JiYYzRlSqMfzTDuNMGzBGs91Ngp7ixz.6bYdav0QYXrdbS";

            if (BCrypt.Net.BCrypt.Verify(password, passwordDB))
            {
                Debug.WriteLine("Khop password");
            }
            else
            {
                Debug.WriteLine("Khong khop password");
            }

            return RedirectToAction("index");
        }

        [HttpPost]
        [Route("save1")]
        public IActionResult Save1(string[] emails)
        {
            foreach (var email in emails)
            {
                Debug.WriteLine(email);
            }
            return RedirectToAction("index");
        }

        [HttpPost]
        [Route("save2")]
        public IActionResult Save2(int[] quantities)
        {
            foreach (var quantity in quantities)
            {
                Debug.WriteLine(quantity);
            }
            return RedirectToAction("index");
        }

    }
}
