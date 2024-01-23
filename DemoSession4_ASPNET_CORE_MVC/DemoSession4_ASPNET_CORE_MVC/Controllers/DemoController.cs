using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoSession4_ASPNET_CORE_MVC.Controllers
{
    [Route("demo")]
    public class DemoController : Controller
    {
        private IConfiguration configuration;

        public DemoController(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            var config1 = configuration["Config1"];
            Debug.WriteLine("Config 1: " + config1);
            var config21 = configuration["Config2:Config21"];
            Debug.WriteLine("Config 2.1: " + config21);
            var info = configuration["Logging:LogLevel:Default"];
            Debug.WriteLine("Default: " + info);
            return View();
        }
    }
}
