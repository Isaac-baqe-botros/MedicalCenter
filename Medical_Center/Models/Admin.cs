using System.ComponentModel.DataAnnotations;

namespace Medical_Center.Models
{

    public class Admin
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Username { get; set; }

        [Required]
        [StringLength(100)]
        public string PasswordHash { get; set; } // Store hashed password for security
    }
}
