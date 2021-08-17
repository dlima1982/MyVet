using System.ComponentModel.DataAnnotations;

namespace MyVet.Web.Models
{
    public class AddUserViewModel
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        [MaxLength(100, ErrorMessage = "El {0} Campo no puede tener mas de {1} Caracteres.")]
        [EmailAddress]
        public string Username { get; set; }

        [Display(Name = "Documento")]
        [MaxLength(20, ErrorMessage = "El {0} Campo no puede tener mas de {1} Caracteres.")]
        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        public string Document { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        public string FirstName { get; set; }

        [Display(Name = "Apellido")]
        [MaxLength(50, ErrorMessage = "El {0} Campo no puede tener mas de {1} Caracteres.")]
        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        public string LastName { get; set; }

        [MaxLength(100, ErrorMessage = "El {0} Campo no puede tener mas de {1} Caracteres.")]
        public string Address { get; set; }

        [Display(Name = "Numero de telefono")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "El {0} Campo debe cumplir entre {2} y  {1} Caracteres.")]
        public string Password { get; set; }

        [Display(Name = "Confirmar Password")]
        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "El {0} Campo debe cumplir entre {2} y  {1} Caracteres.")]
        [Compare("Password")]
        public string PasswordConfirm { get; set; }
    }
}
