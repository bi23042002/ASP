using DemoSession4_ASPNET_CORE_MVC.Models;

namespace DemoSession4_ASPNET_CORE_MVC.Services
{
    public interface RoleService
    {
        public List<Role> findAll();
        public Role findById(int id);
    }
}
