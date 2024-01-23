using DemoSession5_Session.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace DemoSession5_Session.Controllers
{
    [Route("demo")]
    public class ProductService : Controller
    {
       

        [Route("")]
        [Route("~/")]
        [Route("index")]
        public IActionResult Index()
        {
            HttpContext.Session.SetInt32("id", 123);
            HttpContext.Session.SetString("username", "acc1");

            var product = productSevice.Find();
            var s = JsonConvert.SerializeObject(product);
            Debug.WriteLine(s);
            HttpContext.Session.SetString("product", s);

            var products = productSevice.FindAll();
            var s2 = JsonConvert.SerializeObject(products);
            Debug.WriteLine(s2);
            HttpContext.Session.SetString("products", s2);

            // huy session
            HttpContext.Session.Remove("id");

            return RedirectToAction("index2");
        }
        [Route("index2")]
        public IActionResult Index2()
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {
                var id = HttpContext.Session.GetInt32("id");
                Debug.WriteLine("id: " + id);
            }
            if (HttpContext.Session.GetString("username") != null)
            {
                var id = HttpContext.Session.GetString("username");
                Debug.WriteLine("username: " + username);
            }
            if (HttpContext.Session.GetString("product") != null)
            {
                var product = JsonConvert.DeserializeObject<Product> (HttpContext.Session.GetString("product");
                Debug.WriteLine("Product Info");
                Debug.WriteLine("id: " + product.Id);
                Debug.WriteLine("name: " + product.Name);
                Debug.WriteLine("price: " + product.Price);
            }
            if (HttpContext.Session.GetString("products") != null)
            {
                var products = JsonConvert.DeserializeObject<List<Product>>(HttpContext.Session.GetString("products");
                products.ForEach(product =>
                {

                    Debug.WriteLine("id: " + product.Id);
                    Debug.WriteLine("name: " + product.Name);
                    Debug.WriteLine("price: " + product.Price);
                    Debug.WriteLine("---------------");
                });
            }
            return View("Index");
        }
    }
}
