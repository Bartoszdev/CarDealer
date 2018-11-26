using System.ComponentModel.DataAnnotations;

namespace CarDealer.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name ="Nazwa użytkownika")]
        public string UserName { get; set; }
        [Required]
        [Display(Name ="Hasło")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
