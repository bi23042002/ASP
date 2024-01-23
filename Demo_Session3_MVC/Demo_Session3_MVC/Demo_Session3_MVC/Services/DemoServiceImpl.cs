namespace Demo_Session3_MVC.Services
{
    public class DemoServiceImpl : DemoService
    {
        public string Hello()
        {
            return "Hello Service";
        }

        public string Hi(string fullName)
        {
            return "Hi " + fullName;
        }
    }
}
