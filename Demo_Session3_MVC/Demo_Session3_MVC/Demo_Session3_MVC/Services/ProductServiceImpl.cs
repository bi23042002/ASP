using Demo_Session3_MVC.Models;

namespace Demo_Session3_MVC.Services
{
    public class ProductServiceImpl : ProductService
    {
        private List<Product> products;

        public ProductServiceImpl()
        {
            products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Name 1",
                    Photo = "thumb1.gif",
                    Price = 2,
                    Quantity = 2
                },
                new Product
                {
                    Id = 2,
                    Name = "Name 2",
                    Photo = "thumb2.gif",
                    Price = 8,
                    Quantity = 11
                },
                new Product
                {
                    Id = 3,
                    Name = "Name 3",
                    Photo = "thumb3.gif",
                    Price = 9,
                    Quantity = 5
                }
            };
        }

        public Product find(int id)
        {
            return products.SingleOrDefault(p => p.Id == id);
        }

        public List<Product> findAll()
        {
            return products;
        }
    }
}
