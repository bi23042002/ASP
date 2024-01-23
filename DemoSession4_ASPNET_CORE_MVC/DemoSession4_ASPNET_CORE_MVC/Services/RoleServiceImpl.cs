using DemoSession4_ASPNET_CORE_MVC.Models;

namespace DemoSession4_ASPNET_CORE_MVC.Services
{
    public class RoleServiceImpl : RoleService
    {
        private DatabaseContext db;
        public RoleServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }
        public List<Role> findAll()
        {
            return db.Roles.ToList();
        }

        public Role findById(int id)
        {
            return db.Roles.Find(id);
        }
    }
}
