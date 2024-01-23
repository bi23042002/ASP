using DemoSession4_ASPNET_CORE_MVC.Models;

namespace DemoSession4_ASPNET_CORE_MVC.Services
{
    public interface ProductService
    {
        public List<Product> findAll(); 
        public List<Product> findByStatus(bool status);
        public List<Product> findByPrice(double min, double max);
        public List<Product> like1(string keyword);
        public List<Product> like2(string keyword);
        public List<Product> like3(string keyword);
        public List<Product> findByYear(int year);
        public List<Product> findByYearAndMonth(int year, int month);
        public List<Product> findByYearAndMonthAndDay(int year, int month, int day);
        public List<Product> findByDate(DateTime date);
        public List<Product> findByDates(DateTime startDate, DateTime endDate);
        public List<Product> sort1();
        public List<Product> sort2();
        public List<Product> sort3(bool status);
        public List<Product> limit1(int n);
        public List<Product> limit2(int start, int n);
        public List<Product> limit3(int start, int n);
        public List<Product> limit4(int start, int n, bool status);
        public Product findById1(int id);
        public Product findById2(int id);
        public Product findById3(int id);
        public long Sum1();
        public double Sum2();
        public double Sum3(bool status);
        public int count();
        public int count2(bool status);
        public double Min1();
        public double Min2(bool status);
        public bool Create(Product product);
        public bool Update(Product product);
        public bool Delete(int id);
    }
}
