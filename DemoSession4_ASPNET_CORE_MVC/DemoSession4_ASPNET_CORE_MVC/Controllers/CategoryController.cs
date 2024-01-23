using DemoSession4_ASPNET_CORE_MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoSession4_ASPNET_CORE_MVC.Controllers
{
    [Route("category")]
    public class CategoryController : Controller
    {
        private CategoryService categoryService;
       
        public CategoryController(CategoryService _categoryService)
        {
            categoryService = _categoryService;
        }

        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.categories = categoryService.findAll();
            return View();
        }

       
    }
}
