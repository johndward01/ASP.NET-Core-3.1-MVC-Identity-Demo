using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core_Identity_Demo.Models
{
    public class Login
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}
