using Demo_Session3_MVC.Helpers;
using DemoSession4_ASPNET_CORE_MVC.Models;
using DemoSession4_ASPNET_CORE_MVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Globalization;

namespace DemoSession4_ASPNET_CORE_MVC.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        private ProductService productService;
        private CategoryService categoryService;
        private IWebHostEnvironment iWebHostEnvironment;

        public ProductController(ProductService _productService, CategoryService _categoryService, IWebHostEnvironment _iWebHostEnvironment)
        {
            productService = _productService;
            categoryService = _categoryService;
            iWebHostEnvironment = _iWebHostEnvironment;
        }
        
        [Route("")]
        [Route("~/")]
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.products = productService.findAll();
            return View();
        }
        [Route("searchByKeyword")]
        public IActionResult searchByKeyword(string keyword)
        {
            ViewBag.products = productService.like3(keyword);
            ViewBag.keyword = keyword;
            return View("Index");
        }
        [Route("searchByPrice")]
        public IActionResult searchByPrice(double min, double max)
        {
            ViewBag.products = productService.findByPrice(min, max);
            //ViewBag.keyword = keyword;
            return View("Index");
        }
		[Route("Index2")]
		public IActionResult Index2()
		{
			return View("Index2");
		}
		[Route("index2")]
        public IActionResult Indexsta()
        {
            ViewBag.products = productService.findByStatus(true);
            return View("Index");
        }
        [Route("index3")]
        public IActionResult Index3()
        {
            ViewBag.products = productService.findByPrice(25, 50);
            return View("Index");
        }
        [Route("index4")]
        public IActionResult Index4()
        {
            ViewBag.products = productService.like1("produc");
            return View("Index");
        }
        [Route("index5")]
        public IActionResult Index5()
        {
            ViewBag.products = productService.like2("top");
            return View("Index");
        }
        [Route("index6")]
        public IActionResult Index6()
        {
            ViewBag.products = productService.like3("top");
            return View("Index");
        }
        [Route("index7")]
        public IActionResult Index7()
        {
            ViewBag.products = productService.findByYear(2021);
            return View("Index");
        }
        [Route("index8")]
        public IActionResult Index8()
        {
            ViewBag.products = productService.findByYearAndMonth(2021, 9);
            return View("Index");
        }
        [Route("index9")]
        public IActionResult Index9()
        {
            ViewBag.products = productService.findByYearAndMonthAndDay(2021, 10, 21);
            return View("Index");
        }
        [Route("index10")]
        public IActionResult Index10()
        {
            var s = "20/01/2022";
            var date = DateTime.ParseExact(s, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            ViewBag.products = productService.findByDate(date);
            return View("Index");
        }
        [Route("index11")]
        public IActionResult Index11()
        {
            var startDate = DateTime.ParseExact("20/01/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact("20/11/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            ViewBag.products = productService.findByDates(startDate, endDate);
            return View("Index");
        }
        [Route("index12")]
        public IActionResult Index12()
        {
            ViewBag.products = productService.sort1();
            return View("Index");
        }
        [Route("index13")]
        public IActionResult Index13()
        {
            ViewBag.products = productService.sort2();
            return View("Index");
        }
        [Route("index14")]
        public IActionResult Index14()
        {
            ViewBag.products = productService.sort3(true);
            return View("Index");
        }
        [Route("index15")]
        public IActionResult Index15()
        {
            ViewBag.products = productService.limit1(2);
            return View("Index");
        }
        [Route("index16")]
        public IActionResult Index16()
        {
            ViewBag.products = productService.limit2(2, 3);
            return View("Index");
        }
        [Route("index17")]
        public IActionResult Index17()
        {
            ViewBag.products = productService.limit3(2, 4);
            return View("Index");
        }
        [Route("index18")]
        public IActionResult Index18()
        {
            ViewBag.products = productService.limit4(2, 4, true);
            return View("Index");
        }
        [Route("index19")]
        public IActionResult Index19()
        {
            ViewBag.product = productService.findById1(7);
            return View("Index2");
        }
        [Route("index20")]
        public IActionResult Index20()
        {
            ViewBag.product = productService.findById2(7);
            return View("Index2");
        }
        [Route("index21")]
        public IActionResult Index21()
        {
            ViewBag.product = productService.findById3(8);
            return View("Index2");
        }
        [Route("index22")]
        public IActionResult Index22()
        {
            ViewBag.msg = "Sum 1";
            ViewBag.sum = productService.Sum1();
            return View("Index3");
        }
        [Route("index23")]
        public IActionResult Index23()
        {
            ViewBag.msg = "Sum 2";
            ViewBag.sum = productService.Sum2();
            return View("Index3");
        }
        [Route("index24")]
        public IActionResult Index24()
        {
            ViewBag.msg = "Sum 3";
            ViewBag.sum = productService.Sum3(true);
            return View("Index3");
        }
        [Route("index25")]
        public IActionResult Index25()
        {
            ViewBag.msg = "all items";
            ViewBag.sum = productService.count();
            return View("Index3");
        }
        [Route("index26")]
        public IActionResult Index26()
        {
            ViewBag.msg = "all items with status";
            ViewBag.sum = productService.count2(true);
            return View("Index3");
        }
        [Route("index27")]
        public IActionResult Index27()
        {
            var product = new Product
            {
                Name = "ABCDEF",
                Price = 123,
                Quantity = 2,
                Description = "sdfjjkd",
                Created = DateTime.Now,
                Status = true,
                Photo = "a.gif",
                CategoryId = 2
            };
            Debug.WriteLine(productService.Create(product));
            return RedirectToAction("Index");
        }
        [Route("index28")]
        public IActionResult Index28()
        {
            
            Debug.WriteLine(productService.Delete(12));
            return RedirectToAction("Index");
        }
        [Route("index29")]
        public IActionResult Index29()
        {
            var product = productService.findById1(1);
            product.Name = "AA";
            product.Price = 321;
            product.Quantity = 8;
            product.Description = "Hello ";
            product.Status = true;
            product.Status = true;

            Debug.WriteLine(productService.Update(product));
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("add")]
        public IActionResult Add()
        {
            ViewBag.categories = categoryService.findAll();
            var product = new Product();
            return View("Add", product);
        }
        [HttpPost]
        [Route("add")]
        public IActionResult Add(Product product, IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                var fileName = FileHelper.generateFileName(file.FileName);
                var path = Path.Combine(iWebHostEnvironment.WebRootPath, "images", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
            }
            else
            {
                product.Photo = "no-image.png";
            }
            product.Created = DateTime.Now;
            productService.Create(product);
            return RedirectToAction("Index");
        }
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            productService.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            ViewBag.categories = categoryService.findAll();
            var product = productService.findById1(id);
            return View("Edit", product);
        }
        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(Product product, IFormFile file, int id)
        {
            if (file != null && file.Length > 0)
            {
                var fileName = FileHelper.generateFileName(file.FileName);
                var path = Path.Combine(iWebHostEnvironment.WebRootPath, "images", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                product.Photo = fileName;
            }
           
            productService.Update(product);
            return RedirectToAction("Index");
        }
        [Route("searchByDates")]
        public IActionResult SearchByDates(string startDate, string endDate)
        {
            var start = DateTime.ParseExact(startDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            var end = DateTime.ParseExact(startDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
           ViewBag.products = productService.findByDates(start, end);
           
            return View("Index");
        }
	}
}
