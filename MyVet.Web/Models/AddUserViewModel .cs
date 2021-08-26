using System.ComponentModel.DataAnnotations;

namespace MyVet.Web.Models
{
    public class AddUserViewModel : EditUserViewModel
    {
        [Display(Name = "Email")]
        [MaxLength(50, ErrorMessage = "El {0} No puede contener mas de {1} Caracteres.")]
        [Required(ErrorMessage = "El {0} es un campo obligatorio.")]
        [EmailAddress]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "El {0} es un campo obligatorio.")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "El {0} Contener entre {2} y {1} Caracteres")]
        public string Password { get; set; }

        [Display(Name = "Confirmar Password")]
        [Required(ErrorMessage = "El {0} es un campo obligatorio.")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "El {0} Contener entre {2} y {1} Caracteres")]
        [Compare("Password")]
        public string PasswordConfirm { get; set; }
    }
}
