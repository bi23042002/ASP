using DemoSession4_ASPNET_CORE_MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoSession4_ASPNET_CORE_MVC.Controllers
{
    [Route("role")]
    public class RoleController : Controller
    {
        private RoleService roleService;

        public RoleController(RoleService _roleService)
        {
            roleService = _roleService;
        }

        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.roles = roleService.findAll();
            return View();
        }
    }
}
