using System.ComponentModel.DataAnnotations;

namespace UIArtify.Models.Account
{
    public class AddUser
    {
        [Required(ErrorMessage = "The Email field is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "The Login field is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The Password field is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "The Password field is required")]
        [MinLength(6, ErrorMessage = "The Password field must be a minimum of 6 characters")]
        public string Password { get; set; }
    }
}