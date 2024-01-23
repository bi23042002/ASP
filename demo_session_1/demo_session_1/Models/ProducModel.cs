using System.Linq;
namespace demo_session_1.Models
{
    public class ProducModel
    {
       private List<product> products;
        public ProducModel()
        {
            products = new List<product>()
            {
                 new product()
                {
                    Id = 1,
                    Name = "Hihi",
                    price = 3.5,
                    Quarity = 3,
                    photo = "download.jfif",
                    status = true,
                    Created = DateTime.Now.Date,
                    categlory = new categlory()
                    {
                        Id_categlory = 1,
                        Name_categlory = "demo2",
                    }
                },
            };
        }
        public List<product> FindAll()
        {
            return products;
        }
        public product find(int Id)
        {
            return products.SingleOrDefault(p => p.Id == Id);
          
        }
    }
}
