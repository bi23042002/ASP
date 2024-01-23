using Microsoft.AspNetCore.Mvc;

namespace DemoSession5_Session.Controllers
{
    [Route("account")]
    public class AccountController : Controller
    {
        [HttpGet]
        [Route("login")]
        public IActionResult Index()
        {
            return View("login");
        }
        [HttpPost]
        [Route("login")]
        public IActionResult Login(string username , string password)
        {
            if(username == "abc" || password == "123") 
            {
                HttpContext.Session.SetString("username", username);
                return RedirectToAction("Welcome");
            }
            else
            {
                ViewBag.msg = "Invalid";
                // session Flash
                TempData["msg"] = "invalid";
                return RedirectToAction("login");
            }
        }
        [Route("welcome")]
        public IActionResult Welcome()
        {
            ViewBag.username = HttpContext.Session.GetString("username");
            return View("welcome");
        }
        [Route("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction("logn");
        }
    }
}
