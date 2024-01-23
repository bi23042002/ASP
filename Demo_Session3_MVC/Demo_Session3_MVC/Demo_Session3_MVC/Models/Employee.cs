using System.ComponentModel.DataAnnotations;

namespace Demo_Session3_MVC.Models
{
    public class Employee
    {
        [Required]
        [MinLength(3)]
        [MaxLength(10)]
        public string Username { get; set; }

        [Required]
        [RegularExpression("((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,20})")]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Range(18, 120)]
        public int Age { get; set; }

        [Url]
        public string Website { get; set; }
    }
}
