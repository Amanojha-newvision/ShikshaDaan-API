using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    public class SetupAccountDto
    {
        public string SuperAdminEmail { get; set; } = string.Empty;
        [Required]
        public string CreatePassword { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Confirm Password required")]
        [Compare("NewPassword", ErrorMessage = "Password doesn't match.")]
        public string ConfirmPassword { get; set; }
    }
}
