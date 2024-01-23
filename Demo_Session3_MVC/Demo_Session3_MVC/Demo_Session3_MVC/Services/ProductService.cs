using Demo_Session3_MVC.Models;

namespace Demo_Session3_MVC.Services
{
    public interface ProductService
    {
        public List<Product> findAll();

        public Product find(int id);
    }
}
