using System.ComponentModel.DataAnnotations;

namespace UIArtify.Models.Account
{
    public class AddUser
    {
        [Required(ErrorMessage = "The Email field is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The Login field is required")]
        public string Login { get; set; }

        [Required(ErrorMessage = "The Password field is required")]
        [Compare(nameof(ReEnterPassword))]
        public string Password { get; set; }

        [Required(ErrorMessage = "The Password field is required")]
        [MinLength(6, ErrorMessage = "The Password field must be a minimum of 6 characters")]
        public string ReEnterPassword { get; set; }
    }
}