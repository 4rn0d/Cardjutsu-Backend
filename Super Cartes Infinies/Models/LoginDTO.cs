using System.ComponentModel.DataAnnotations;

namespace Super_Cartes_Infinies.Models
{
    public class LoginDTO
    {
        [Required]
        public String Username { get; set; } = null!;
        [Required]
        public String Password { get; set; } = null!;
    }
}
