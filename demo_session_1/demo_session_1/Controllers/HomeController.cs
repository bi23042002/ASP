using Microsoft.AspNetCore.Mvc;

namespace demo_session_1.Controllers
{
    [Route("Home")]

    public class HomeController : Controller
    {
        [Route("~/")]
        [Route("index")]


        public IActionResult Index()
        {
            return View();
        }
    }
}
