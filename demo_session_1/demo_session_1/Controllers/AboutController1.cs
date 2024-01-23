using Microsoft.AspNetCore.Mvc;

namespace demo_session_1.Controllers
{
    [Route("about")]
    public class AboutController1 : Controller
    {
       
       
        [Route("Index")]
        
     
        public IActionResult Index()
        {
            return View();
        }
    }
}
