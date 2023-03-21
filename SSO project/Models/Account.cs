using System.ComponentModel.DataAnnotations;

namespace SSO_project.Models
{
    public class Account
    {
        [Required]
        public string userName { get; set; }
        [Required]
        public string password { get; set; }
    }
}
