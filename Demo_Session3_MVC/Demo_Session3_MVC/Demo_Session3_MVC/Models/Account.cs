namespace Demo_Session3_MVC.Models
{
    public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public string[] Languages { get; set; }
        public string Gender { get; set; }
        public string Cert { get; set; }
        public string Role { get; set; }
        public int Id { get; set; }
        public Address Address { get; set; }
        public DateTime Birthday { get; set; }
    }
}
