using Microsoft.AspNetCore.Mvc;

namespace demo_session_1.Controllers
{
    [Route("news")]
    public class NewsController : Controller
    {
        
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
