using demo_session_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace demo_session_1.Controllers
{
    public class ProductController : Controller
    {
        
        public IActionResult Index()
        {
            var product_detai = new ProducModel();
            ViewBag.products = product_detai.FindAll();


            return View("index");
           
        }
        [Route("detail/{id}")]
         public IActionResult detail(int id)
        {
            var product_detai = new ProducModel();
            ViewBag.products = product_detai.FindAll();
            return View("index");

        }
    }
}
