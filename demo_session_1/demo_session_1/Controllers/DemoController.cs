using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace demo_session_1.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.id = "pc12";
            ViewBag.status = false;
            ViewBag.width = 400;
            ViewBag.height = "auto";
            ViewBag.name = new List<string>

            {
                "name1","name2","name3","name4","name5","name6",
            };
            return View();
        }
        public IActionResult Index1(int id)
        {
            Debug.WriteLine("id" + id);

            return View("Index1");
        }
        public IActionResult Index2(int id, string username)
        {
            Debug.WriteLine("id " + id);
            Debug.WriteLine("password " + username);
            return View("Index2");
        }
       
    }
}