using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace demo_session_1.Controllers
{
    [Route("abc")]
    public class Demo2Controller : Controller
    {
        [Route("xyz")]
        //[Route("")]
        //[Route("~/")]
        public IActionResult Index()
        {
            return View();
        }
            [Route("index2/{id}")]
        public IActionResult Index2(int id)
        {
            Debug.WriteLine(id);
            return View("index2");
            
        }
        [Route("index4/{id}/{username}")]
        public IActionResult Index2(int id , string name)
        {
            Debug.WriteLine(id);
            Debug.WriteLine(name);
            return View("index4");

        }
        [Route("index5")]
        public IActionResult Index5(int id, string name)
        {
            Debug.WriteLine(id);
            Debug.WriteLine(name);
            return View("index5");

        }
    }
}
