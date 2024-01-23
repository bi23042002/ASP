using Demo_Session3_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Session3_MVC.Controllers
{
    [Route("employee")]
    public class EmployeeController : Controller
    {
        [Route("")]
        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View("Index", new Employee());
        }

        [HttpPost]
        [Route("save")]
        public IActionResult Save(Employee employee)
        {
            // Custom Validation
            if (employee.Username != null && employee.Username == "abc")
            {
                ModelState.AddModelError("Username", "Username da ton tai");
            }

            if (ModelState.IsValid)
            {
                return View("Success");
            }
            else
            {
                return View("Index");
            }
        }

    }
}
