using System.ComponentModel.DataAnnotations;

namespace DynamicDataModeling.Authentication
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Password { get; set; }
    }
}
