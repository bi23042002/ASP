namespace Demo_Session3_MVC.Services
{
    public class RectangleServiceImpl : RectangleService
    {
        private CalculateService calculateService;

        public RectangleServiceImpl(CalculateService _calculateService)
        {
            calculateService = _calculateService;
        }

        public double Area(double a, double b)
        {
            return calculateService.mul(a, b);
        }

        public double Perimeter(double a, double b)
        {
            return calculateService.mul(calculateService.add(a, b), 2);
        }
    }
}
