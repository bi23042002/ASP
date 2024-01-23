using Demo_Session3_MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Session3_MVC.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        private ProductService productService;

        public ProductController(ProductService _productService)
        {
            productService = _productService;
        }

        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.products = productService.findAll();
            return View();
        }

        [Route("details/{id}")]
        public IActionResult Details(int id)
        {
            ViewBag.product = productService.find(id);
            return View("Details");
        }
    }
}
