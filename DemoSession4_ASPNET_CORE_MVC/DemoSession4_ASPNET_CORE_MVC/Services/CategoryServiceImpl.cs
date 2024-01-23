using DemoSession4_ASPNET_CORE_MVC.Models;

namespace DemoSession4_ASPNET_CORE_MVC.Services
{
    public class CategoryServiceImpl : CategoryService
    {
        private DatabaseContext db;
        public CategoryServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }
        public List<Category> findAll()
        {
            return db.Categories.ToList();
        }
    }
}
