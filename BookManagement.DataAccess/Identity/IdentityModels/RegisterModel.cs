using System.ComponentModel.DataAnnotations;

namespace BookManagement.DataAccess.Identity.IdentityModels
{
    public class RegisterModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
