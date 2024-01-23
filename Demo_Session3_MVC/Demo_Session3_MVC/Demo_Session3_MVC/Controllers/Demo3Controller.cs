using Demo_Session3_MVC.Helpers;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo_Session3_MVC.Controllers
{
    [Route("demo3")]
    public class Demo3Controller : Controller
    {
        private IWebHostEnvironment webHostEnvironment;

        public Demo3Controller(IWebHostEnvironment _webHostEnvironment)
        {
            webHostEnvironment = _webHostEnvironment;
        }

        [Route("index")]
        [Route("")]        
        public IActionResult Index()
        {
            var name = Guid.NewGuid().ToString().Replace("-", "");
            Debug.WriteLine(name);
            return View();
        }

        [HttpPost]
        [Route("upload1")]
        public IActionResult Upload1(IFormFile file)
        {
            Debug.WriteLine("file name: " + file.FileName);
            Debug.WriteLine("file size(byte): " + file.Length);
            Debug.WriteLine("file type: " + file.ContentType);
            var fileName = FileHelper.generateFileName(file.FileName);
            var path = Path.Combine(webHostEnvironment.WebRootPath, "upload", fileName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }
            return RedirectToAction("index");
        }

        [HttpPost]
        [Route("upload2")]
        public IActionResult Upload2(IFormFile[] files)
        {
            if (files != null && files.Length > 0)
            {
                foreach (var file in files)
                {
                    Debug.WriteLine("file name: " + file.FileName);
                    Debug.WriteLine("file size(byte): " + file.Length);
                    Debug.WriteLine("file type: " + file.ContentType);
                    Debug.WriteLine("------------------------------");
                    var fileName = FileHelper.generateFileName(file.FileName);
                    var path = Path.Combine(webHostEnvironment.WebRootPath, "upload", fileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                }
            }
            return RedirectToAction("index");
        }

    }
}
