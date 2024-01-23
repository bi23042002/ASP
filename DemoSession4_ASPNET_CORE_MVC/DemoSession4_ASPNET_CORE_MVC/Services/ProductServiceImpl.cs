using DemoSession4_ASPNET_CORE_MVC.Models;
using System.Diagnostics;

namespace DemoSession4_ASPNET_CORE_MVC.Services
{
    public class ProductServiceImpl : ProductService

    {
        private DatabaseContext db;
        public ProductServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }
        public List<Product> findAll()
        {
            return db.Products.ToList();
        }

        public List<Product> findByDate(DateTime date)
        {
            return db.Products.Where(p => p.Created == date).ToList();
        }

        public List<Product> findByDates(DateTime startDate, DateTime endDate)
        {
            return db.Products.Where(p => p.Created >= startDate && p.Created <= endDate).ToList();
        }

        public List<Product> findByPrice(double min, double max)
        {
            return db.Products.Where(p => p.Price <= min && p.Price >= max).ToList();
        }

        public List<Product> findByStatus(bool status)
        {
            return db.Products.Where(p => p.Status == status).ToList();
        }

        public List<Product> findByYear(int year)
        {
            return db.Products.Where(p => p.Created.Year == year).ToList();
        }

        public List<Product> findByYearAndMonth(int year, int month)
        {
            return db.Products.Where(p => p.Created.Year == year && p.Created.Month == month).ToList();
        }

        public List<Product> findByYearAndMonthAndDay(int year, int month, int day)
        {
            return db.Products.Where(p => p.Created.Year == year && p.Created.Month == month && p.Created.Day == day).ToList();
        }

        public List<Product> like1(string keyword)
        {
            return db.Products.Where(p => p.Name.StartsWith(keyword)).ToList();
        }

        public List<Product> like2(string keyword)
        {
            return db.Products.Where(p => p.Name.EndsWith(keyword)).ToList();
        }

        public List<Product> like3(string keyword)
        {
            return db.Products.Where(p => p.Name.Contains(keyword)).ToList();
        }

        public List<Product> sort1()
        {
            return db.Products.OrderBy(p => p.Price).ToList();
        }
        public List<Product> sort2()
        {
            return db.Products.OrderByDescending(p => p.Price).ToList();
        }
        public List<Product> sort3(bool status)
        {
            return db.Products.Where(p => p.Status == status).OrderByDescending(p => p.Price).ToList();
        }
        public List<Product> limit1(int n)
        {
            return db.Products.Take(n).ToList();
        }
        public List<Product> limit2(int start, int n)
        {
            return db.Products.Skip(start).Take(n).ToList();
        }
        public List<Product> limit3(int start, int n)
        {
            return db.Products.OrderByDescending(p => p.Price).Skip(start).Take(n).ToList();
        }
        public List<Product> limit4(int start, int n, bool status)
        {
            return db.Products.Where(p => p.Status == status).OrderByDescending(p => p.Price).Skip(start).Take(n).ToList();
        }

        public Product findById1(int id)
        {
            return db.Products.Find(id);
        }
        public Product findById2(int id)
        {
            return db.Products.SingleOrDefault(p => p.Id == id);
        }
        public Product findById3(int id)
        {
            return db.Products.Where(p => p.Id == id).FirstOrDefault();
        }

        public long Sum1()
        {
            return db.Products.Sum(p => p.Quantity);
        }
        public double Sum2()
        {
            return db.Products.Sum(p => p.Quantity * p.Price);
        }
        public double Sum3(bool status)
        {
            return db.Products.Where(p => p.Status == status).Sum(p => p.Quantity * p.Price);
        }
        public int count()
        {
            return db.Products.Count();
        }
        public int count2(bool status)
        {
            return db.Products.Count(p => p.Status == status);
        }
        public double Min1()
        {
            return db.Products.Min(p => p.Price);
        }
        public double Min2(bool status)
        {
            return db.Products.Where(p => p.Status == status).Min(p => p.Price);
        }

        public bool Create(Product product)
        {
            try
            {
                db.Products.Add(product);
                return db.SaveChanges() > 0;
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
                return false;

            }
        }
        public bool Update(Product product)
        {
            try
            {
                db.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return db.SaveChanges() > 0;
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
                return false;

            }
        }
        public bool Delete(int id)
        {
            try
            {
                db.Products.Remove(db.Products.Find(id));
                return db.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
