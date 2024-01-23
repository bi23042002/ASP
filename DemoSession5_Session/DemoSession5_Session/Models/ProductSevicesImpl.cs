namespace DemoSession5_Session.Models
{
    public interface ProductSevicesImpl : ProductSevices
    {
        public List<Product> FindAll()
        {
            return new List<Product>
            {
             new Product()
            {
                Id = 1,
                Name = "Name 1",
                Price = 5.6
             },
            new Product()
            {
                Id = 2,
                Name = "Name 2",
                Price = 5.6
            },
            new Product()
            {
                Id = 3,
                Name = "Name 3",
                Price = 5.6
            }
            };
        }
    }
}
