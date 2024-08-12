using System.ComponentModel.DataAnnotations;

namespace Medical_Center.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password
        {
            get; set;
        }
        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
