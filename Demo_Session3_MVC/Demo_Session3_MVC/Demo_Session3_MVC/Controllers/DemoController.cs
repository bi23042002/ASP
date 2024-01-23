using Demo_Session3_MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Session3_MVC.Controllers
{
    [Route("demo")]
    public class DemoController : Controller
    {
        private DemoService demoService;
        private CalculateService calculateService;
        private RectangleService rectangleService;

        public DemoController(DemoService _demoService, CalculateService _calculateService, RectangleService _rectangleService) {
            demoService = _demoService;
            calculateService = _calculateService;
            rectangleService = _rectangleService;
        }

        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.msg = demoService.Hello();
            ViewBag.msg2 = demoService.Hi("ABC");
            ViewBag.result1 = calculateService.add(1, 2);
            ViewBag.result2 = calculateService.mul(2, 3);
            var a = 5;
            var b = 10;
            ViewBag.area = rectangleService.Area(a, b);
            ViewBag.perimeter = rectangleService.Perimeter(a, b);
            return View();
        }
    }
}
