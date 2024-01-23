namespace Demo_Session3_MVC.Services
{
    public class CalculateServiceImpl : CalculateService
    {
        public double add(double a, double b)
        {
            return a + b;
        }

        public double mul(double a, double b)
        {
            return a * b;
        }
    }
}
