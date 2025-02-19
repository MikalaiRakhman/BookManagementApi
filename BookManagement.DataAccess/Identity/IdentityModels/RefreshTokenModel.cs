using System.ComponentModel.DataAnnotations;

namespace BookManagement.DataAccess.Identity.IdentityModels
{
    public class RefreshTokenModel
    {
        [Required]
        public string RefreshToken { get; set; }
    }
}
